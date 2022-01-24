using System.Collections;

using Tehi.Data;
using Tehi.Data.TehiEntities;

namespace CardLib
{
    public class TehiGame: IEnumerable<PlayingCard>
    {
        public TehiGame()
        {
            CanLogin = true;
            Message = "Enter your game name and click login";
        }

        private CardDeck deck = new CardDeck();
        
        private List<PlayingCard> hand = new List<PlayingCard>();

        private DataAccessor tda = new DataAccessor();

        private Player? player;

        public int HandsDealtInThisGame { get; private set; }

        public int BestHandScoreInThisGame { get; private set; }

        public bool CanSwapCards { get; private set; }
        
        public bool CanDeal { get; private set; }

        public bool CanLogin { get; private set; }

        public string Message { get; private set; }

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

            HandsDealtInThisGame++;

            ScoreUpdate();

            CanSwapCards = true;
        }

        public void SwapCard(int cardIndex)
        {
            deck.Add(hand[cardIndex]);
            deck.Shuffle();

            hand[cardIndex] = deck.Deal();
            hand[cardIndex].FaceUp = true;

            ScoreUpdate();

            CanSwapCards = false;
        }

        public void Login(string name)
        {
            if (name.Length < 3)
            {
                Message = "Game name must be 3 or more characters.";

                return;
            }

            CanDeal = true;
            CanLogin = false;

            player = tda.LookupPlayer(name);

            if (player != null)
            {
                Message = $"Player found. Overall best score is {player.BestHandScore} in {player.HandsDealt}.";

                return;
            }

            player = new Player();
            player.Name = name;

            tda.Add(player);

            tda.SaveChanges();

            Message = $"New player {name} added to database.";
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

        private void ScoreUpdate()
        {
            if (Score > BestHandScoreInThisGame)
            {
                BestHandScoreInThisGame = Score;
            }

            if ((Score > player!.BestHandScore) ||
               ((Score == player.BestHandScore) && (HandsDealtInThisGame < player.HandsDealt)))
            {
                player.BestHandScore = Score;
                player.HandsDealt = HandsDealtInThisGame;
                tda.SaveChanges();
                Message = "New all-time best score " + Score + " in " + player.HandsDealt + " hands";
            }
            else
            {
                Message = "...";
            }
        }
    }
}
