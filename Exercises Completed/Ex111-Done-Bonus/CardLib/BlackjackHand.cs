namespace CardLib
{
	public class BlackjackHand : GameHand
	{
		public BlackjackHand() { splitFromIndex = -1; } // minus 1 means not split from another hand
		public BlackjackHand(int splitFromIndex) { this.splitFromIndex = splitFromIndex; }

		private int doubledDown = 1;
		public int DoubledDown { get { return doubledDown; } set { doubledDown = value; } }

		private int splitFromIndex;
		public int SplitFromIndex { get { return splitFromIndex; } }

		private int[] CardValues;

		public bool HasAce
		{
			get
			{
				foreach (PlayingCard card in Hand)
					if (card.Rank == PlayingCard.Ace) return true;
				return false;
			}
		}

		public override long Worth
		{
			get
			{
				if (Score > 21) return -1;
				return Score;
			}
		}

		public override long Score
		{
			get
			{
				SetCardValuesToDefault();
				int total = 0;
				total = Evaluate();
				if (total > 21)
				{
					while (WeHaveAHighAce && total > 21)
					{
						SetNextHighAceLow();
						total = Evaluate();
					}
				}
				return total;
			}
		}

		private void SetCardValuesToDefault()
		{
			CardValues = new int[Hand.Count];
			for (int i = 0; i < CardValues.Length; i++)
			{
				if (Hand[i].Rank == PlayingCard.Ace) CardValues[i] = 11;
				else if (Hand[i].Rank >= PlayingCard.Jack) CardValues[i] = 10;
				else CardValues[i] = Hand[i].Rank;
			}
		}

		private bool WeHaveAHighAce
		{
			get
			{
				foreach (int Value in CardValues)
				{
					if (Value == 11) return true;
				}
				return false;
			}
		}

		private void SetNextHighAceLow()
		{
			for (int i = 0; i < CardValues.Length; i++)
			{
				if (CardValues[i] == 11)
				{
					CardValues[i] = 1;
					return;
				}
			}
		}

		private int Evaluate()
		{
			int total = 0;
			foreach (int Value in CardValues) total += Value;
			if ((Hand.Count == 5) && (total < 21)) total = 21;
			return total;
		}
	}
}
