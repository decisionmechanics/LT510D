namespace HiLoGame
{
    public class Game
    {
        private readonly Random _random;
        private int _secret;
        private int _totalAttempts;
        private int _successfulGuesses;

        public Game()
        {
            _random = new Random();

            _secret = GetSecret();
        }

        public event EventHandler? GuessMade;

        public double AverageAttempts => _successfulGuesses > 0  ? (double)_totalAttempts / _successfulGuesses : 0;

        public int CurrentAttempts { get; private set; }

        public void New()
        {
            _secret = GetSecret();

            CurrentAttempts = 0;
        }

        public GuessStatus MakeGuess(int guess)
        {
            CurrentAttempts++;
            _totalAttempts++;

            GuessStatus guessStatus = GuessStatus.Correct;

            if (guess < _secret)
            {
                guessStatus = GuessStatus.TooLow;
            }
            else if (guess > _secret)
            {
                guessStatus = GuessStatus.TooHigh;
            }
            else
            {
                _successfulGuesses++;
            }

            GuessMade?.Invoke(this, EventArgs.Empty);

            return guessStatus;
        }

        private int GetSecret() => _random.Next(1, 101);
    }
}
