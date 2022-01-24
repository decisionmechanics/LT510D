namespace HiLoGame
{
    public partial class MainForm : Form
    {
        private readonly Game _game;
        private readonly ScoreForm _scoreForm;

        public MainForm()
        {
            InitializeComponent();

            _game = new Game();

            _scoreForm = new ScoreForm();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            messageLabel.Text = "What number between 1 and 100 am I thinking of?";
            attemptsLabel.Text =string.Empty;

            _game.GuessMade += UpdateAttempts;
        }

        private void UpdateAttempts(object? sender, EventArgs e)
        {
            attemptsLabel.Text = $"{_game.CurrentAttempts} attempt(s)";
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _game.New();

            messageLabel.Text = "What number between 1 and 100 am I thinking of?";
            attemptsLabel.Text = string.Empty;

            guessButton.Enabled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(guessTextBox.Text, out int guess))
            {
                if (guess is >= 1 and <= 100)
                {
                    GuessStatus guessStatus = _game.MakeGuess(guess);

                    if (guessStatus == GuessStatus.TooLow)
                    {
                        messageLabel.Text = $"Awww... {guess} is too low. Try again.";
                    }
                    else if (guessStatus == GuessStatus.TooHigh)
                    {
                        messageLabel.Text = $"Whoa! {guess} is too high. Try again.";
                    }
                    else
                    {
                        messageLabel.Text = $"Congratulations! I was thinking of {guess}. You took {_game.CurrentAttempts} attempt(s). Want to play again?";

                        _scoreForm.Update(_game.AverageAttempts);

                        guessButton.Enabled = false;
                    }

                    guessTextBox.Text = string.Empty;

                    return;
                }
            }

            messageLabel.Text = "Your guess must be a whole number between 1 and 100. Try again.";
        }

        private void attemptsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _scoreForm.Show();
        }
    }
}