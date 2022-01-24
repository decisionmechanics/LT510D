namespace CardLib
{
    public enum CardSuit { Clubs, Diamonds, Hearts, Spades }

    public class PlayingCard
    {
        public const int Ace = 1;
        public const int Jack = 11;
        public const int Queen = 12;
        public const int King = 13;

        public bool FaceUp { get; set; }

        public int Rank { get; private set; }

        public CardSuit Suit { get; private set; }

        public PlayingCard(int rank, CardSuit suit)
        {
            ValidateRange(rank, Ace, King);

            Rank = rank;
            Suit = suit;

            FaceUp = false;
        }

        public void Flip()
        {
            FaceUp = !FaceUp;
        }

        public int Index
        {
            get
            {
                if (!FaceUp) return 0;

                return (int)Suit * 13 + Rank;
            }
        }

        public string Code
        {
            get
            {
                if (!FaceUp) return "XX";
                string suits = "CDHS";
                string ranks = " A23456789TJQK"; // Begins with a space
                return "" + ranks[Rank] + suits[(int)Suit];
            }
        }

        public override string ToString()
        {
            if (!FaceUp) return "XX";
            
            string suits = "\u2663\u2666\u2665\u2660";
            string ranks = " A23456789TJQK";

            return "" + ranks[Rank] + suits[(int)Suit];
        }

        protected void ValidateRange(int val, int min, int max)
        {
            if ((val < min) || (val > max))
            {
                throw new ArgumentException("Value of " + val + " is not between " + min + " and " + max);
            }
        }
    }
}