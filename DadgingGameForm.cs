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
        }
    }
}
