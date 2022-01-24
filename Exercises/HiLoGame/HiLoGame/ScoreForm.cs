namespace HiLoGame
{
    public partial class ScoreForm : Form
    {
        private Game? _game;

        public ScoreForm()
        {
            InitializeComponent();
        }

        public void Initialize(Game game)
        {
            _game = game;

            game.SuccessfulGuessMade += Update;
        }

        private void Update(object? sender, EventArgs e)
        {
            scoresListBox.Items.Insert(0, $"At {DateTime.Now.ToShortTimeString()} the average # of attempts was {_game!.AverageAttempts:N2}");
        }
    }
}
