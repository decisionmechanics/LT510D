using System;
using System.Collections.Generic;

namespace CardLib
{
	public class KnuthShuffler : IShuffler
	{
		public void Shuffle(List<PlayingCard> deck)
		{
			for (int i = 0; i < deck.Count; i++)
			{
				int swapIndex = RandomNumber.Next(0, deck.Count);
				PlayingCard temp = deck[swapIndex];
				deck[swapIndex] = deck[i];
				deck[i] = temp;
			}
		}
	}
	public class ModifiedKnuthShuffler : IShuffler
	{
		public void Shuffle(List<PlayingCard> deck)
		{
			for (int i = 0; i < deck.Count; i++)
			{
				int swapIndex = RandomNumber.Next(i, deck.Count);
				PlayingCard temp = deck[swapIndex];
				deck[swapIndex] = deck[i];
				deck[i] = temp;
			}
		}
	}

}
