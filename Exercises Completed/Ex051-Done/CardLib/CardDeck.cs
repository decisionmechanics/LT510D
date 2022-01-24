namespace CardLib
{
    public class CardDeck
    {
        private Stack<PlayingCard> cardStack = new Stack<PlayingCard>();

        public CardDeck()
        {
            Array suitChoices = Enum.GetValues(typeof(CardSuit));

            foreach (CardSuit s in suitChoices)
            {
                for (int r = PlayingCard.Ace; r <= PlayingCard.King; r++)
                {
                    PlayingCard card;

                    if (r < PlayingCard.Jack) card = new PlayingCard(r, s);
                    else card = new FaceCard(r, s);

                    card.FaceUp = true;

                    cardStack.Push(card);
                }
            }
        }

        public PlayingCard Deal()
        {
            PlayingCard temp = cardStack.Pop();
            temp.FaceUp = false;

            return temp;
        }

        public void Add(PlayingCard card)
        {
            card.FaceUp = true;
            cardStack.Push(card);
        }

        public override string ToString()
        {
            string rep = string.Empty;

            foreach (PlayingCard card in cardStack)
            {
                rep = rep + card + " ";
            }

            return rep.Trim();
        }
    }
}
