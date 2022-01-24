namespace CardLib
{
    public class FaceCard : PlayingCard
    {
        public int Eyes { get; private set; }

        public FaceCard(int rank, CardSuit suit) : base(rank, suit)
        {
            ValidateRange(rank, Jack, King);

            Eyes = 2;

            if ((rank == Jack) && (suit == CardSuit.Hearts))
            {
                Eyes = 1;
            }

            if ((rank == Jack) && (suit == CardSuit.Spades))
            {
                Eyes = 1;
            }

            if ((rank == King) && (suit == CardSuit.Diamonds))
            {
                Eyes = 1;
            }
        }

        public override string ToString()
        {
            if (!FaceUp) return base.ToString();
            
            return base.ToString() + Eyes;
        }
    }
}