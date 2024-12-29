using System.Drawing.Drawing2D;
using DodgingGame.UI;
using NAudio.Wave;

namespace DodgingGame
{
   
    public partial class DodgingGameForm : Form
    {
        private int playerX;
        private int playerY;
        private int playerWidth = 40;
        private int playerHeight = 45;
        private int playerSpeed = 10;

        private List<Obstacle> obstacles = new List<Obstacle>();
        private int obstacleWidth = 20;
        private int obstacleHeight = 20;
        private int obstacleSpeed = 5;

        private List<PowerUp> powerUps = new List<PowerUp>();
        private int powerUpWidth = 30;
        private int powerUpHeight = 30;

        private bool isInvincible = false;
        private bool isSlowRain = false;
        private int powerUpDuration = 5000;
        private DateTime powerUpStartTime;

        private Image umbrellaImage;
        private Image raincoatImage;


        private int score = 0;
        
        private System.Windows.Forms.Timer gameTimer = new System.Windows.Forms.Timer();
        private Random random = new Random();

        private bool moveLeft, moveRight, moveUp, moveDown;

        private Image playerImage;
        private Image obstacleImage;

        private WaveOutEvent backgroundPlayer;
        private WaveOutEvent effectPlayer;
        private AudioFileReader backgroundMusic;
        private AudioFileReader collisionSound;

        private int level = 1;
        private int pointsToNextLevel = 150;



        public DodgingGameForm()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            this.KeyPreview = true;

            backgroundMusic = new AudioFileReader("Sounds/gameplay.mp3");
            backgroundPlayer = new WaveOutEvent();
            backgroundPlayer.Init(backgroundMusic);

            collisionSound = new AudioFileReader("Sounds/collision.mp3");
            effectPlayer = new WaveOutEvent();

            backgroundPlayer.PlaybackStopped += (s, e) =>
            {
                backgroundMusic.Position = 0;
                backgroundPlayer.Play();
            };

            playerImage = Image.FromFile("Images/Bax.jpg");
            obstacleImage = Image.FromFile("Images/water.png");
            umbrellaImage = Image.FromFile("Images/umbrella.png");
            raincoatImage = Image.FromFile("Images/raincoat.png");

            this.KeyDown += Form1_KeyDown;
            this.KeyUp += Form1_KeyUp;

            this.DoubleBuffered = true;

            gameTimer.Interval = 20;
            gameTimer.Tick += GameTimer_Tick;

            this.KeyDown += Form1_KeyDown;
            gamePanel.Paint += GamePanel_Paint;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            playerX = gamePanel.Width / 2;
            playerY = gamePanel.Height - playerHeight;
            obstacles.Clear();
            score = 0;
            level = 1;
            obstacleSpeed = 5;

            labelScore.Text = $"Score: {score}";
            labelLevel.Text = $"Level: {level}";

            if (backgroundPlayer.PlaybackState != PlaybackState.Playing)
            {
                backgroundMusic.Position = 0;
                backgroundPlayer.Play();
            }

            gameTimer.Start();

            this.Focus();
        }

        // Game Loop

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (moveLeft && playerX > 0)
                playerX -= playerSpeed;
            if (moveRight && playerX + playerWidth < gamePanel.Width)
                playerX += playerSpeed;
            if (moveUp && playerY > 0)
                playerY -= playerSpeed;
            if (moveDown && playerY + playerHeight < gamePanel.Height)
                playerY += playerSpeed;


            for (int i = 0; i < obstacles.Count; i++)
            {
                obstacles[i].Rect = new Rectangle(
                    obstacles[i].Rect.X,
                    obstacles[i].Rect.Y + obstacleSpeed,
                    obstacleWidth,
                    obstacleHeight
                );
            }

            obstacles.RemoveAll(o => o.Rect.Y > gamePanel.Height);

            if (random.Next(0, 100) < 10)
            {
                int obstacleX = random.Next(0, gamePanel.Width - obstacleWidth);
                obstacles.Add(new Obstacle
                {
                    Rect = new Rectangle(obstacleX, 0, obstacleWidth, obstacleHeight)
                });
            }

            for (int i = 0; i < powerUps.Count; i++)
            {
                powerUps[i].Rect = new Rectangle(
                    powerUps[i].Rect.X,
                    powerUps[i].Rect.Y + obstacleSpeed,
                    powerUpWidth,
                    powerUpHeight
                );
            }

            powerUps.RemoveAll(p => p.Rect.Y > gamePanel.Height);

            if (random.Next(0, 1000) < 2)
            {
                int powerUpX = random.Next(0, gamePanel.Width - powerUpWidth);
                bool isUmbrella = random.Next(0, 2) == 0;

                powerUps.Add(new PowerUp
                {
                    Rect = new Rectangle(powerUpX, 0, powerUpWidth, powerUpHeight),
                    Type = isUmbrella ? "umbrella" : "raincoat"
                });
            }

            Rectangle player = new Rectangle(playerX, playerY, playerWidth, playerHeight);

            foreach (var obstacle in obstacles)
            {
                if (!isInvincible && player.IntersectsWith(obstacle.Rect))
                {
                    gameTimer.Stop();
                    GameSession.CurrentScore = score;

                    try
                    {
                        if (effectPlayer.PlaybackState == PlaybackState.Playing)
                        {
                            effectPlayer.Stop();
                        }
                        effectPlayer.Init(collisionSound);
                        collisionSound.Position = 0;
                        effectPlayer.Play();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error playing collision sound: {ex.Message}", "Sound Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    MessageBox.Show($"Game Over! Score: {score} Level: {level}", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    using (var highScoreForm = new HighScoreForm())
                    {
                        highScoreForm.ShowDialog();
                    }

                    return;
                }
            }

            foreach (var powerUp in powerUps.ToList())
            {
                if (player.IntersectsWith(powerUp.Rect))
                {
                    powerUps.Remove(powerUp);

                    if (powerUp.Type == "umbrella")
                    {
                        isInvincible = true;
                        powerUpStartTime = DateTime.Now;
                    }
                    else if (powerUp.Type == "raincoat")
                    {
                        isSlowRain = true;
                        powerUpStartTime = DateTime.Now;
                        obstacleSpeed = Math.Max(obstacleSpeed - 3, 2);
                    }
                }
            }


            if ((isInvincible || isSlowRain) && (DateTime.Now - powerUpStartTime).TotalMilliseconds > powerUpDuration)
            {
                if (isSlowRain)
                {
                    obstacleSpeed += 3;
                }

                isInvincible = false;
                isSlowRain = false;
            }

            score++;
            GameSession.CurrentScore = score;            
            if (score % pointsToNextLevel == 0)
            {
                level++;
                obstacleSpeed += 2;

            }

            labelScore.Text = $"Score: {score}";
            labelLevel.Text = $"Level: {level}";


            gamePanel.Invalidate();
        }

        private void GamePanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (isInvincible)
            {
                using (SolidBrush glowBrush = new SolidBrush(Color.FromArgb(100, Color.Yellow)))
                {
                    g.FillEllipse(glowBrush, playerX - 5, playerY - 5, playerWidth + 10, playerHeight + 10);
                }
            }


            g.DrawImage(playerImage, playerX, playerY, playerWidth, playerHeight);

            foreach (var obstacle in obstacles)
            {
                g.DrawImage(obstacleImage, obstacle.Rect.X, obstacle.Rect.Y, obstacleWidth, obstacleHeight);
            }

            foreach (var powerUp in powerUps)
            {
                if (powerUp.Type == "umbrella")
                    g.DrawImage(umbrellaImage, powerUp.Rect.X, powerUp.Rect.Y, powerUpWidth, powerUpHeight);
                else if (powerUp.Type == "raincoat")
                    g.DrawImage(raincoatImage, powerUp.Rect.X, powerUp.Rect.Y, powerUpWidth, powerUpHeight);
            }

        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            Color topColor = Color.LightSkyBlue;
            Color bottomColor = Color.DarkBlue;

            if (isInvincible)
            {
                topColor = Color.Yellow;
                bottomColor = Color.Orange;
            }
            else if (isSlowRain)
            {
                topColor = Color.LightGray;
                bottomColor = Color.DarkGray;
            }

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
