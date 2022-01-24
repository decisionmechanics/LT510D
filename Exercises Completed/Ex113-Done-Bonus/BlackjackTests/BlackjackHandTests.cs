using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardLib;

namespace BlackjackTests
{
	[TestClass]
	public class BlackjackHandTests
	{
		[TestMethod]
		public void Creation()
		{
			BlackjackHand hand = new BlackjackHand();
			Assert.IsNotNull(hand);
		}

		[TestMethod]
		public void ValueTest()
		{
			BlackjackHand hand = new BlackjackHand();
			hand.AddCard(new PlayingCard(PlayingCard.King, CardSuit.Clubs));
			hand.AddCard(new PlayingCard(2, CardSuit.Clubs));
			Assert.AreEqual(12, hand.Score);
			hand.AddCard(new PlayingCard(9, CardSuit.Spades));
			Assert.AreEqual(21, hand.Score);
		}

		[TestMethod]
		public void CountTest()
		{
			BlackjackHand hand = new BlackjackHand();
			hand.AddCard(new PlayingCard(PlayingCard.King, CardSuit.Clubs));
			Assert.AreEqual(1, hand.Count);
			hand.AddCard(new PlayingCard(2, CardSuit.Clubs));
			Assert.AreEqual(2, hand.Count);
			hand.AddCard(new PlayingCard(3, CardSuit.Spades));
			Assert.AreEqual(3, hand.Count);
			hand.AddCard(new PlayingCard(4, CardSuit.Spades));
			Assert.AreEqual(4, hand.Count);
		}

		//[TestMethod]
		//public void CompareTest()
		//{
		//    BlackjackHand hand = new BlackjackHand();
		//    IComparer<PlayingCard> comparer = (IComparer<PlayingCard>)hand;
		//    PlayingCard card = new PlayingCard(3, PlayingCard.SPADES);
		//    FaceCard face = new FaceCard(PlayingCard.JACK, PlayingCard.HEARTS);
		//    int ans = comparer.Compare(card, face);
		//    Assert.AreEqual(-1, ans);
		//    ans = comparer.Compare(face, card);
		//    Assert.AreEqual(+1, ans);
		//    FaceCard face2 = new FaceCard(PlayingCard.JACK, PlayingCard.SPADES);
		//    ans = comparer.Compare(face, face2);
		//    Assert.AreEqual(0, ans);
		//}

		//[TestMethod]
		//public void RelationalOperatorsTest()
		//{
		//    BlackjackHand hand1 = new BlackjackHand();
		//    hand1.AddCard(new FaceCard(PlayingCard.KING, PlayingCard.CLUBS));
		//    hand1.AddCard(new PlayingCard(2, PlayingCard.CLUBS));

		//    BlackjackHand hand2 = new BlackjackHand();
		//    hand2.AddCard(new FaceCard(PlayingCard.JACK, PlayingCard.HEARTS));
		//    hand2.AddCard(new PlayingCard(10, PlayingCard.SPADES));
		//    Assert.IsTrue(hand2 > hand1);
		//    Assert.IsTrue(hand1 < hand2);
		//}
	}
}
