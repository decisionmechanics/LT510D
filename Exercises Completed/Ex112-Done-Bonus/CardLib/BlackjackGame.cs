using System;
using System.Collections.Generic;

// Blackjack game logic - uncoupled from view (view is stateless)
// Uses state pattern

namespace CardLib
{
	/// <summary>
	/// Operation enumeration - all available game operations
	/// </summary>
	public enum BlackjackOp
	{
		Bet, Deal, Hit, Stand, Split, Insurance, EvenMoney, Surrender, DoubleDown
	}

	/// <summary>
	/// Blackjack dispatch logic - outer class for actual logic in inner classes.
	/// </summary>
	public class BlackjackGame : Util.Publisher, IStackable
	{
		// Bet control fields

		private int bet;								// Amount of bet
		private int betPaid;							// Amount last hand paid.
		private int insPaid;							// Amount last insurance paid.
		private int credits;							// To track win/loose

		// Playing card and hand fields

		private CardShoe shoe;								// Shoe for the game
		private BlackjackHand dealerHand;					// Dealer's hand
		private List<BlackjackHand> playerHands;			// For player hands
		public BlackjackHand PlayerHands(int playerNumber) { return playerHands[playerNumber]; }
		public int NumberOfPlayerHands { get { return playerHands.Count; } }

		private int currentPlayerHandIndex;					// Current hand (default 0)

		// State and configuration fields

		private BlackjackGameState state;					// Current state
		private BlackjackConfiguration config;				// Current configuration

		// Properties

		public int Credits { get { return credits; } set { credits = value; } }
		public int BetAmount { get { return bet; } }		// Allow view of bet
		public int BetPaid { get { return betPaid; } }		// Return what last bet paid
		public int InsurancePaid { get { return insPaid; } }	// What last insurance bet paid

		public CardShoe Shoe { get { return shoe; } }		// Expose the shoe
		public GameHand SystemHand { get { return dealerHand; } }
		public GameHand PlayerHand { get { return playerHands[0]; } }

		public int CurrentPlayerHandIndex { get { return currentPlayerHandIndex; } }
		public BlackjackHand FindPlayerHandByIndex(int ix)
		{
			if (ix >= playerHands.Count) return null;
			return (BlackjackHand)playerHands[ix];
		}

		// Constructor

        public BlackjackGame()								// Constructor
		{
			state = new StateWaitingForBet(this);           // Initial state
			config = BlackjackConfiguration.Instance;		// Create configuration
			if (BlackjackConfiguration.HasBeenSaved) config.Load();			// Load configuration
			dealerHand = new BlackjackHand();				// Create dealer hand
			playerHands = new List<BlackjackHand>();		// Allow for splitting
			playerHands.Add(new BlackjackHand());			// Create 1st player hand.
			shoe = new CardShoe(config.Data.DecksInShoe);	// Create shoe
		}

		// Method dispatch from Blackjack game (all work actually done in state objects)

		private bool[] availableOps;
		public bool OpAvailable(BlackjackOp action)						// What we can do in this state
		{
			return availableOps[(int)action];
		}
		public void Bet() { state.Bet(); Notify(); }					// Bet dispatch
		public void Deal() { state.Deal(); Notify(); }					// Deal dispatch
		public void Hit() { state.Hit(); Notify(); }					// Hit dispatch
		public void Stand() { state.Stand(); Notify(); }				// Stand dispatch
		public void Split() { state.Split(); Notify(); }				// Split dispatch
		public void Insurance() { state.Insurance(); Notify(); }		// Insurance dispatch
		public void EvenMoney() { state.EvenMoney(); Notify(); }		// Even money dispatch
		public void Surrender() { state.Surrender(); Notify(); }		// Surrender dispatch
		public void DoubleDown() { state.DoubleDown(); Notify(); }		// Double down dispatch
		public void SwapCard(int ix) { state.SwapCard(ix);  Notify(); }	// Not in this game
		/// <summary>
		/// Base class for all state classes. Inner class. All methods here throw
		/// error exceptions. They should be overridden as appropriate in the
		/// game-state derived classes.
		/// </summary>
		abstract class BlackjackGameState
		{
			protected BlackjackGame outer;
			public BlackjackGameState(BlackjackGame outer)
			{
				this.outer = outer;
				outer.availableOps = new bool[] { false, false, false, false, false, false, false, false, false };
			}
			public virtual void Bet() { Invalid(); }
			public virtual void Deal() { Invalid(); }
			public virtual void Hit() { Invalid(); }
			public virtual void Stand() { Invalid(); }
			public virtual void Split() { Invalid(); }
			public virtual void Insurance() { Invalid(); }
			public virtual void EvenMoney() { Invalid(); }
			public virtual void Surrender() { Invalid(); }
			public virtual void DoubleDown() { Invalid(); }
			public virtual void SwapCard(int ix) { Invalid(); }
			public static void Invalid() { throw new InvalidOperationException(); }
		}
		/// <summary>
		/// Inner state class - waiting for a bet and that's all (no bet yet placed)
		/// </summary>
		class StateWaitingForBet : BlackjackGameState
		{
			public StateWaitingForBet(BlackjackGame outer) : base(outer)
			{
				outer.availableOps[(int)(int)BlackjackOp.Bet] = true;
			}
			public override void Bet()
			{
				outer.ChangeBet();
				if (outer.bet != 0) outer.state = new StateStartOfHand(outer);
			}
		}
		/// <summary>
		/// Inner state class - at start of dealing a hand (bets have been placed
		/// although bets can still be changed). Can only deal or bet.
		/// </summary>
		class StateStartOfHand : BlackjackGameState
		{
			public StateStartOfHand(BlackjackGame outer) : base(outer)
			{
				outer.availableOps[(int)BlackjackOp.Bet] = true;
				outer.availableOps[(int)BlackjackOp.Deal] = true;
			}
			public override void Bet()
			{
				outer.ChangeBet();
				if (outer.bet == 0) outer.state = new StateWaitingForBet(outer);
			}
			public override void Deal()
			{
				outer.insPaid = 0;
				outer.betPaid = 0;
				foreach (PlayingCard card in outer.SystemHand) outer.shoe.Add(card);
				foreach (BlackjackHand hand in outer.playerHands)
				{
					foreach (PlayingCard card in hand) outer.shoe.Add(card);
					hand.Text = "";
				}
				outer.SystemHand.ClearHand();
				outer.SystemHand.Text = "";
				outer.playerHands.Clear();
				BlackjackHand playerHand = new BlackjackHand();
				outer.playerHands.Add(playerHand);
				outer.currentPlayerHandIndex = 0;
				playerHand.AddCard(outer.shoe.Deal());
				outer.dealerHand.AddCard(outer.shoe.Deal());
				outer.dealerHand[0].FaceUp = false;
				playerHand.AddCard(outer.shoe.Deal());
				outer.dealerHand.AddCard(outer.shoe.Deal());

				if (playerHand.Score == 21)
				{
					playerHand.Text = "blackjack";
					if ((outer.dealerHand[1].Rank == PlayingCard.Ace) && (outer.config.Data.InsuranceAllowed || outer.config.Data.OnlyEvenMoneyAllowed))
					{
						outer.state = new StateWaitingForEvenMoneyDecision(outer);
					}
					else
					{
						outer.dealerHand[0].FaceUp = true;
						if (outer.dealerHand.Score == 21) outer.dealerHand.Text = "blackjack";
						else
						{
							outer.Win((int)(outer.bet * outer.config.Data.PayoffOnBlackjack));
						    outer.dealerHand.Text = "" + outer.dealerHand.Score;
						}
					}
				}
				else
				{
					playerHand.Text = string.Empty;
					outer.state = new StateFirstTwoCardsDelt(outer);
				}
			}
		}

		/// <summary>
		/// Inner state class - 1st two cards have been delt to player & dealer
		/// Can always hit, stand or double down. Can surrender if allowed in
		/// configuration. Can split on pairs as allowed in configuration.
		/// Can insure on dealer ace as allowed in configuration.
		/// Can get even money on dealer ace with player blackjack as allowed in
		/// configuration.
		/// </summary>
		class StateFirstTwoCardsDelt : BlackjackGameState
		{
			public StateFirstTwoCardsDelt(BlackjackGame outer) : base(outer)
			{
				outer.availableOps[(int)BlackjackOp.Hit] = true;
				outer.availableOps[(int)BlackjackOp.Stand] = true;
				outer.availableOps[(int)BlackjackOp.DoubleDown] = true;
				outer.availableOps[(int)BlackjackOp.Surrender] = outer.config.Data.SurrenderAllowed;
				outer.availableOps[(int)BlackjackOp.Split] = outer.HandCanSplit(0);
				outer.availableOps[(int)BlackjackOp.Insurance] = (outer.dealerHand[1].Rank == PlayingCard.Ace) && outer.config.Data.InsuranceAllowed;
			}
			public override void Hit()
			{
				outer.state = new StateDealingToPlayer(outer);
				outer.DoHit();
			}
			public override void Stand()
			{
				outer.state = new StateDealingToPlayer(outer);
				outer.DoStand();
			}
			public override void Split()
			{
				outer.state = new StateDealingToPlayer(outer);
				outer.DoSplit();
			}
			public override void DoubleDown()
			{
				int cpix = outer.currentPlayerHandIndex;
				BlackjackHand hand = (BlackjackHand) outer.playerHands[cpix];
				hand.AddCard(outer.shoe.Deal());
				hand.DoubledDown = 2;
				if (outer.currentPlayerHandIndex == 0)
				{
					outer.state = new StateStartOfHand(outer);
					outer.DealOutDealerHand();
					outer.PayOrCollectFromPlayer();
				}
				else
				{
					if (hand.Score > 21) hand.Text = "bust";
					else hand.Text = "" + hand.Score;
					outer.currentPlayerHandIndex = hand.SplitFromIndex;
					outer.state = new StateDealingToPlayer(outer);
				}
			}
			public override void Surrender()
			{
				BlackjackHand hand = (BlackjackHand) outer.playerHands[0];
				if ((outer.config.Data.LateSurrender) && (outer.dealerHand.Score == 21) && (outer.dealerHand.Count == 2))
				{
					outer.Loose(outer.bet);
					outer.dealerHand.Text = "blackjack";
					hand.Text = "" + hand.Score + " lost";
				}
				else
				{
					outer.Loose((int)(outer.bet * .5 + .5));
					outer.dealerHand.Text = "" + outer.dealerHand.Score;
					hand.Text = "surrender";
				}
				outer.dealerHand[0].FaceUp = true;
				outer.state = new StateStartOfHand(outer);
			}
			public override void Insurance()
			{
				BlackjackHand phand = (BlackjackHand) outer.playerHands[0];
				BlackjackHand dhand = outer.dealerHand;
				if (dhand.Score == 21)
				{
					dhand[0].FaceUp = true;
					dhand.Text = "blackjack";
					phand.Text = "" + phand.Score + " insured";
					outer.insPaid = outer.bet;
					outer.credits += outer.insPaid;
					outer.Loose(outer.bet);
					outer.state = new StateStartOfHand(outer);
				}
				else 
				{
					phand.Text = string.Empty;
					outer.insPaid = -(outer.bet/2);
					outer.credits += outer.insPaid;
					if (outer.HandCanSplit(0)) outer.state = new StateWaitingForSplitDecision(outer);
					else outer.state = new StateDealingToPlayer(outer);
				}
			}
		}

		/// <summary>
		/// Inner state class to handle dealing to the player.
		/// Only hit and stand are allowed.
		/// </summary>
		class StateDealingToPlayer : BlackjackGameState
		{
			public StateDealingToPlayer(BlackjackGame outer) : base(outer)
			{
				outer.availableOps[(int)BlackjackOp.Hit] = true;
				outer.availableOps[(int)BlackjackOp.Stand] = true;
			}
			public override void Hit()
			{
				outer.DoHit();
			}
			public override void Stand()
			{
				outer.DoStand();
			}
		}

		/// <summary>
		/// Inner class to use when waiting for decision to split
		/// Note that hit or stand will presume the state should have been
		/// dealing to player so a quick switch and dispatch is done from here.
		/// </summary>
		class StateWaitingForSplitDecision : BlackjackGameState
		{
			public StateWaitingForSplitDecision(BlackjackGame outer) : base(outer)
			{
				outer.availableOps[(int)BlackjackOp.Hit] = true;
				outer.availableOps[(int)BlackjackOp.Stand] = true;
				outer.availableOps[(int)BlackjackOp.Split] = true;
			}
			public override void Hit()
			{
				outer.state = new StateDealingToPlayer(outer);
				outer.DoHit();
			}
			public override void Stand()
			{
				outer.DoStand();
			}
			public override void Split()
			{
				outer.state = new StateDealingToPlayer(outer);
				outer.DoSplit();
			}
		}

		/// <summary>
		/// Inner class to use when waiting for an even money decision
		/// </summary>
		class StateWaitingForEvenMoneyDecision : BlackjackGameState
		{
			public StateWaitingForEvenMoneyDecision(BlackjackGame outer) : base(outer)
			{
				outer.availableOps[(int)BlackjackOp.Stand] = true;
				outer.availableOps[(int)BlackjackOp.EvenMoney] = true;
			}
			public override void Stand()
			{
				outer.DoStand();
			}
			public override void EvenMoney()
			{
				outer.Win(outer.bet);
				outer.dealerHand[0].FaceUp = true;
				outer.dealerHand.Text = "Even Money";
				((BlackjackHand)outer.playerHands[0]).Text = "Even Money";
				outer.state = new StateStartOfHand(outer);
			}
		}

		// Service routines ------------------------------------------------------

		/// <summary>
		/// Service routine to finish dealing cards to the dealer
		/// </summary>
        private void DealOutDealerHand()
		{
			dealerHand[0].FaceUp = true;
			dealerHand.Text = String.Empty + dealerHand.Score;
			if (AllPlayerHandsBust) return;
			while (DealerShouldDraw)
			{
				dealerHand.AddCard(shoe.Deal());
				dealerHand.Text = String.Empty + dealerHand.Score;
			}
			if (dealerHand.Score > 21) dealerHand.Text = "bust";
			else if ((dealerHand.Score == 21) && (dealerHand.Count == 2)) dealerHand.Text = "blackjack";
		}
		/// <summary>
		/// Service routine to determine if all players have busted
		/// </summary>
		private bool AllPlayerHandsBust
		{
			get
			{
				for (int i = 0; i < this.playerHands.Count; i++)
				{
					BlackjackHand hand = (BlackjackHand) playerHands[i];
					if (hand.Score <= 21) return false;
				}
				return true;
			}
		}
		/// <summary>
		/// Service routine to determine if dealer should draw
		/// </summary>
		private bool DealerShouldDraw
		{
			get
			{
				if (dealerHand.Score < 17) return true;
				if (dealerHand.Score > 17) return false;
				if (config.Data.DealerDrawsOnSoft17 && dealerHand.HasAce) return true;
				return false;
			}
		}
		/// <summary>
		/// Service routine to pay off or collect for all player hands
		/// </summary>
		private void PayOrCollectFromPlayer()
		{
			for (int i = 0; i < this.playerHands.Count; i++)
			{
				BlackjackHand hand = (BlackjackHand)playerHands[i];
				if (hand.Score > 21)
				{
					Loose(bet * hand.DoubledDown);
					hand.Text = "bust";
				}
				else if (dealerHand.Score > 21)
				{
					Win(bet * hand.DoubledDown);
					hand.Text = "" + hand.Score + " paid";
				}
				else if ((dealerHand.Score == 21) && (dealerHand.Count == 2))
				{
					Loose(bet);
					hand.Text = "" + hand.Score + " lost";
				}
				else if (hand.Worth > dealerHand.Worth)
				{
					Win(bet * hand.DoubledDown);
					hand.Text = "" + hand.Score + " paid";
				}
				else if (hand.Worth < dealerHand.Worth)
				{
					Loose(bet * hand.DoubledDown);
					hand.Text = "" + hand.Score + " lost";
				}
				else if ((hand.Score == dealerHand.Score) && config.Data.PayDealerOnTie)
				{
					Loose(bet * hand.DoubledDown);
					hand.Text = "" + hand.Score + " lost";
				}
				else
				{
					Win(0);
					hand.Text = "" + hand.Score + " push";
				}
			}
		}
        /// <summary>
		/// Service routine to change the amount the player has bet.
		/// </summary>
		private void ChangeBet()
		{
			bet = bet + config.Data.BetIncrement;
			if (bet > config.Data.MaximumBet) bet = 0;
		}
		/// <summary>
		/// Service method to check if a hand can split
		/// </summary>
		/// <param name="handID"></param>
		/// <returns></returns>
		private bool HandCanSplit(int handID)
		{
			BlackjackHand playerHand = (BlackjackHand)playerHands[handID];
			if (playerHand.Count != 2) return false;					// Can only split on 1st two cards
			if ((playerHand[0].Rank == PlayingCard.Ace) &&
				(playerHand[1].Rank == PlayingCard.Ace) &&
				(playerHands.Count < config.Data.MaximumSplitsOnAces))	// Have we split too much on aces?
					return true;										// ... yes then no more splitting
			if ((playerHand[0].Rank < 10) &&
				(playerHand[0].Rank != PlayingCard.Ace) &&				// Does player have a pair?
			    (playerHand[0].Rank == playerHand[1].Rank) &&
			    (playerHands.Count < config.Data.MaximumSplitsOnNonAces))
					return true;	// ... yes then allow split.
			if (TenVal(playerHand[0]) &&								// Does player have a ten pair?
				TenVal(playerHand[1]) &&
				config.Data.CanSplitOn10s) return true;					// ... yes then split if allowed.
			return false;												// Anything else is false
		}
		/// <summary>
		/// Check to see if this is a ten-valued card
		/// </summary>
		private static bool TenVal(PlayingCard card)
		{
			if (card.Rank >= 10) return true;							// Rank of 10?
			return false;												// Nothing else is 10.
		}
		/// <summary>
		/// Service routine to handle hitting of the player hand(s)
		/// </summary>
		private void DoHit()
		{
			int cpix = currentPlayerHandIndex;
			BlackjackHand hand = (BlackjackHand) playerHands[cpix];
			hand.AddCard(shoe.Deal());
			if (HandCanSplit(cpix))
			{
				hand.Text = "" + hand.Score;
				state = new StateWaitingForSplitDecision(this);
			}
			else if (hand.Score >= 21)
			{
				if (currentPlayerHandIndex == 0)
				{
					DealOutDealerHand();
					PayOrCollectFromPlayer();
					state = new StateStartOfHand(this);
				}
				else
				{
					hand.Text = "bust";
					if (hand.Score == 21) hand.Text = "21";
					currentPlayerHandIndex = hand.SplitFromIndex;
				}
			}
			else hand.Text = string.Empty;
		}
		/// <summary>
		/// Service routine to process when a player stands on a hand
		/// </summary>
		private void DoStand()
		{
			if (currentPlayerHandIndex == 0)
			{
				DealOutDealerHand();
				PayOrCollectFromPlayer();
				state = new StateStartOfHand(this);
			}
			else
			{
				BlackjackHand hand = (BlackjackHand) playerHands[currentPlayerHandIndex];
				hand.Text = "" + hand.Score;
				currentPlayerHandIndex = hand.SplitFromIndex;
			}
		}
		/// <summary>
		/// Service routine to do splitting of a player hand
		/// </summary>
		private void DoSplit()
		{
			BlackjackHand hand1 = (BlackjackHand) playerHands[currentPlayerHandIndex];
			BlackjackHand hand2 = new BlackjackHand(currentPlayerHandIndex);
			playerHands.Add(hand2);
			hand2.AddCard(hand1[1]);
			hand2.Text = hand2.Score.ToString();
			hand1.RemoveAt(1);
			hand1.Text = hand1.Score.ToString();
			currentPlayerHandIndex = playerHands.Count-1;
		}
		/// <summary>
		/// Service routine to record wins
		/// </summary>
		protected virtual void Win(int amount)
		{
			betPaid += amount;
			credits += amount;
		}
		/// <summary>
		/// Service routine to record losses.
		/// </summary>
		protected void Loose(int amount)
		{
			Win(-amount);
		}
		public void Stack(string cardCode, int position)
		{
			if (!isStacked) shoe.WasReset += ShoeWasReset;
			shoe.Stack(cardCode, position);
			isStacked = true;
		}
		private void ShoeWasReset(object sender, EventArgs e)
		{
			isStacked = false;
			shoe.WasReset -= ShoeWasReset;
		}
		public CardDeck DeckToStack { get { return shoe; } }
		private bool isStacked;
		public bool IsStacked { get { return isStacked; } }
	}
}
