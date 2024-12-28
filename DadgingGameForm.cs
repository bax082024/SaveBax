namespace DodgingGame
{
    public partial class DadgingGameForm : Form
    {
        private int playerX; // Player's horizontal position
        private int playerWidth = 50; // Width of the player
        private int playerHeight = 20; // Height of the player
        private int playerSpeed = 10; // Player's movement speed

        private List<Rectangle> obstacles = new List<Rectangle>(); // Obstacles
        private int obstacleWidth = 20;
        private int obstacleHeight = 20;
        private int obstacleSpeed = 5;

        private int score = 0; // Game score
        private System.Windows.Forms.Timer gameTimer = new System.Windows.Forms.Timer();
        private Random random = new Random(); // Random number generator

        private bool moveLeft, moveRight, moveUp, moveDown;



        public DadgingGameForm()
        {
            InitializeComponent();

            // Handle key events for player movement
            this.KeyDown += Form1_KeyDown;
            
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
            obstacles.Clear();
            score = 0;

            // Start the game
            gameTimer.Start();
        }

        // Game Loop

        private void GameTimer_Tick(object sender, EventArgs e)
        {
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
            Rectangle player = new Rectangle(playerX, gamePanel.Height - playerHeight, playerWidth, playerHeight);
            foreach (var obstacle in obstacles)
            {
                if (player.IntersectsWith(obstacle))
                {
                    gameTimer.Stop();
                    MessageBox.Show($"Game Over! Score: {score}", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            // Update score
            score++;
            labelScore.Text = $"Score: {score}";

            // Redraw the game
            gamePanel.Invalidate();
        }

      

        private void GamePanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Draw the player
            g.FillRectangle(Brushes.Blue, playerX, gamePanel.Height - playerHeight, playerWidth, playerHeight);

            // Draw the obstacles
            foreach (var obstacle in obstacles)
            {
                g.FillRectangle(Brushes.Red, obstacle);
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







    }
}
