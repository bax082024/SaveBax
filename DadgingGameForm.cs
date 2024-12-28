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
        private Timer gameTimer = new Timer(); // Timer for the game loop
        private Random random = new Random(); // Random number generator


        public DadgingGameForm()
        {
            InitializeComponent();

            // Handle key events for player movement
            this.KeyDown += Form1_KeyDown;

            // Attach the Paint event to the gamePanel
            gamePanel.Paint += GamePanel_Paint;

            // Configure the game timer
            gameTimer.Interval = 20; // 20ms per tick (50 frames per second)
            gameTimer.Tick += GameTimer_Tick;
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

        }
    }
}
