using System.Drawing.Drawing2D;
using DodgingGame.UI;
using NAudio.Wave;

namespace DodgingGame
{
   
    public partial class DodgingGameForm : Form
    {
        private int playerX; // Player's horizontal position
        private int playerY; // Player's vertical position
        private int playerWidth = 40; // Width of the player
        private int playerHeight = 45; // Height of the player
        private int playerSpeed = 10; // Player's movement speed

        private List<Rectangle> obstacles = new List<Rectangle>(); // Obstacles
        private int obstacleWidth = 20;
        private int obstacleHeight = 20;
        private int obstacleSpeed = 5;

        private List<Rectangle> powerUps = new List<Rectangle>(); // Power-ups
        private int powerUpWidth = 30;
        private int powerUpHeight = 30;

        // Power-up state
        private bool isInvincible = false;
        private bool isSlowRain = false;
        private int powerUpDuration = 5000; // 5 seconds
        private DateTime powerUpStartTime;

        // Load power-up images
        private Image umbrellaImage;
        private Image raincoatImage;


        private int score = 0; // Game score
        

        private System.Windows.Forms.Timer gameTimer = new System.Windows.Forms.Timer();
        private Random random = new Random(); // Random number generator

        private bool moveLeft, moveRight, moveUp, moveDown;

        // Load images
        private Image playerImage;
        private Image obstacleImage;

        private WaveOutEvent backgroundPlayer;
        private WaveOutEvent effectPlayer;
        private AudioFileReader backgroundMusic;
        private AudioFileReader collisionSound;

        private int level = 1; // Current game level
        private int pointsToNextLevel = 150; // Points required to level up



        public DodgingGameForm()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            this.KeyPreview = true;

            // Load the background music
            backgroundMusic = new AudioFileReader("Sounds/gameplay.mp3");
            backgroundPlayer = new WaveOutEvent();
            backgroundPlayer.Init(backgroundMusic);

            // Load collision sound effect
            collisionSound = new AudioFileReader("Sounds/collision.mp3");
            effectPlayer = new WaveOutEvent();

            // Play background music on loop
            backgroundPlayer.PlaybackStopped += (s, e) =>
            {
                backgroundMusic.Position = 0; // Restart the music
                backgroundPlayer.Play();
            };

            // Load the images
            playerImage = Image.FromFile("Images/Bax.jpg");
            obstacleImage = Image.FromFile("Images/water.png");
            umbrellaImage = Image.FromFile("Images/umbrella.png");
            raincoatImage = Image.FromFile("Images/raincoat.png");

            // Handle key events for player movement
            this.KeyDown += Form1_KeyDown;
            this.KeyUp += Form1_KeyUp;

            // Enable double buffering for smoother graphics
            this.DoubleBuffered = true;


            // Configure the game timer
            gameTimer.Interval = 20; // 20ms per tick (50 frames per second)
            gameTimer.Tick += GameTimer_Tick;

            this.KeyDown += Form1_KeyDown;
            gamePanel.Paint += GamePanel_Paint;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            // Reset game state
            playerX = gamePanel.Width / 2; // Start in the middle
            playerY = gamePanel.Height - playerHeight;
            obstacles.Clear();
            score = 0;
            level = 1;
            obstacleSpeed = 5;

            // Update UI
            labelScore.Text = $"Score: {score}";
            labelLevel.Text = $"Level: {level}";

            // Start background music
            if (backgroundPlayer.PlaybackState != PlaybackState.Playing)
            {
                backgroundMusic.Position = 0; // Reset music
                backgroundPlayer.Play();
            }

            // Start the game
            gameTimer.Start();

            this.Focus();
        }

        // Game Loop

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            // Move the player
            if (moveLeft && playerX > 0)
                playerX -= playerSpeed;
            if (moveRight && playerX + playerWidth < gamePanel.Width)
                playerX += playerSpeed;
            if (moveUp && playerY > 0)
                playerY -= playerSpeed;
            if (moveDown && playerY + playerHeight < gamePanel.Height)
                playerY += playerSpeed;


            // Move obstacles down
            for (int i = 0; i < obstacles.Count; i++)
            {
                obstacles[i] = new Rectangle(
                    obstacles[i].X,
                    obstacles[i].Y + obstacleSpeed,
                    obstacleWidth,
                    obstacleHeight
                );
            }

            // Remove obstacles that move off the screen
            obstacles.RemoveAll(o => o.Y > gamePanel.Height);

            // Add new obstacles randomly
            if (random.Next(0, 100) < 10) // 10% chance to spawn
            {
                int obstacleX = random.Next(0, gamePanel.Width - obstacleWidth);
                obstacles.Add(new Rectangle(obstacleX, 0, obstacleWidth, obstacleHeight));
            }

            // Check for collisions
            Rectangle player = new Rectangle(playerX, playerY, playerWidth, playerHeight);

            foreach (var obstacle in obstacles)
            {
                if (player.IntersectsWith(obstacle))
                {
                    gameTimer.Stop();
                    GameSession.CurrentScore = score;

                    // Ensure collision sound plays
                    try
                    {
                        if (effectPlayer.PlaybackState == PlaybackState.Playing)
                        {
                            effectPlayer.Stop();
                        }
                        effectPlayer.Init(collisionSound);
                        collisionSound.Position = 0; // Reset sound position
                        effectPlayer.Play();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error playing collision sound: {ex.Message}", "Sound Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    MessageBox.Show($"Game Over! Score: {score} Level: {level}", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Open the high score form
                    using (var highScoreForm = new HighScoreForm())
                    {
                        highScoreForm.ShowDialog();
                    }


                    return;
                }
            }

            // Update score and level
            score++;
            GameSession.CurrentScore = score;            
            if (score % pointsToNextLevel == 0) // Level up
            {
                level++;
                obstacleSpeed += 2; // Increase obstacle speed

            }

            // Update UI
            labelScore.Text = $"Score: {score}";
            labelLevel.Text = $"Level: {level}";


            // Redraw the game
            gamePanel.Invalidate();
        }



        private void GamePanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Draw the player
            g.DrawImage(playerImage, playerX, playerY, playerWidth, playerHeight);

            // Draw the obstacles
            foreach (var obstacle in obstacles)
            {
                g.DrawImage(obstacleImage, obstacle.X, obstacle.Y, obstacleWidth, obstacleHeight);
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            // Draw the gradient background for the entire form
            using (LinearGradientBrush gradientBrush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.LightSkyBlue,  // Top color
                Color.DarkBlue,        // Bottom color
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(gradientBrush, this.ClientRectangle);
            }
        }


        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                moveLeft = true;
            else if (e.KeyCode == Keys.Right)
                moveRight = true;
            else if (e.KeyCode == Keys.Up)
                moveUp = true;
            else if (e.KeyCode == Keys.Down)
                moveDown = true;
        }

        private void Form1_KeyUp(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                moveLeft = false;
            else if (e.KeyCode == Keys.Right)
                moveRight = false;
            else if (e.KeyCode == Keys.Up)
                moveUp = false;
            else if (e.KeyCode == Keys.Down)
                moveDown = false;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left:
                    moveLeft = true;
                    break;
                case Keys.Right:
                    moveRight = true;
                    break;
                case Keys.Up:
                    moveUp = true;
                    break;
                case Keys.Down:
                    moveDown = true;
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
       

        private void SaveHighScore(string playerName, int score)
        {
            var highScores = JsonHelper.LoadHighScores();
            highScores.Add(new HighScore { PlayerName = playerName, Score = score });
            highScores.Sort((x, y) => y.Score.CompareTo(x.Score));
            JsonHelper.SaveHighScores(highScores);
        }

        private void buttonHighScores_Click(object sender, EventArgs e)
        {
            using (var highScoreForm = new HighScoreForm())
            {
                highScoreForm.ShowDialog();
            }
        }

        
    }
}
