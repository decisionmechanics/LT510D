using System.Collections;

namespace CardLib
{
    public class TehiGame: IEnumerable<PlayingCard>
    {
        private CardDeck deck = new CardDeck();
        
        private List<PlayingCard> hand = new List<PlayingCard>();

        public int HandsDealt { get; private set; }

        public int BestHandScore { get; private set; }

        public int Score
        {
            get
            {
                int totalEyes = 0;
                int totalRank = 0;

                foreach (PlayingCard card in hand)
                {
                    // Determine if it is a FaceCard by checking its type, not its rank ...
                    // If so, cast it as a FaceCard and add the number of eyes to totalEyes ...
                    // If not, add the rank to the totalRank ...

                    if (card is FaceCard)
                    {
                        FaceCard face = (FaceCard)card; 
                        totalEyes += face.Eyes;
                    }
                    else
                        totalRank += card.Rank;
                }

                return totalRank * totalEyes;
            }
        }

        public void Deal()
        {
            foreach (PlayingCard card in hand)
                deck.Add(card);

            hand.Clear();
            deck.Shuffle();

            for (int i = 0; i < 5; i++)
            {
                PlayingCard card = deck.Deal();
                card.FaceUp = true;
                hand.Add(card);
            }

            HandsDealt++;

            if (Score > BestHandScore)
                BestHandScore = Score;
        }

        public IEnumerator<PlayingCard> GetEnumerator()
        {
            return hand.GetEnumerator();
        }

        public override string ToString()
        {
            string rep = string.Empty;

            foreach (PlayingCard card in hand)
                rep = rep + card + " ";

            return rep.Trim();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return hand.GetEnumerator();
        }
    }
}
