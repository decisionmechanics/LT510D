using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardLib;

namespace BlackjackTests
{
	[TestClass]
	public class BlackjackGameTests
	{
		[TestInitialize]
		public void ResetPreferenceDefaults()
		{
			BlackjackConfiguration.Instance.ResetDefaults();
		}

		[TestMethod]
		public void Creation()
		{
			BlackjackGame game = new BlackjackGame();
			Assert.IsNotNull(game);
		}

		[TestMethod]
		public void InitialStateTest()
		{
			BlackjackGame game = new BlackjackGame();
			Assert.AreEqual(0, game.PlayerHand.Count);
			Assert.AreEqual(0, game.SystemHand.Count);
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Bet));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Deal));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Hit));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Stand));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Split));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Insurance));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.EvenMoney));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Surrender));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.DoubleDown));
		}

		[TestMethod]
		public void BetTest()
		{
			BlackjackGame game = new BlackjackGame();
			game.Bet();
			Assert.AreEqual(5, game.BetAmount);
			game.Bet();
			Assert.AreEqual(10, game.BetAmount);
			for (int i = 0; i < 9; i++) game.Bet();
			Assert.AreEqual(0, game.BetAmount);
			game.Bet();
			Assert.AreEqual(5, BlackjackConfiguration.Instance.Data.BetIncrement);
		}

		[TestMethod]
		public void CanDealTest()
		{
			BlackjackGame game = new BlackjackGame();
			game.Bet();
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Bet));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Deal));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Hit));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Stand));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Split));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Insurance));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.EvenMoney));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Surrender));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.DoubleDown));
		}

		[TestMethod]
		public void NormalDealTest()
		{
			BlackjackGame game = null;
			do
			{
				game = new BlackjackGame();
				game.Bet();
				game.Deal();
			} while ((game.SystemHand.Score == 21) || (game.PlayerHand.Score == 21) ||
				(game.SystemHand[1].Rank == PlayingCard.Ace) ||
				(game.PlayerHand[0].Rank == game.PlayerHand[1].Rank));
			Assert.AreEqual(2, game.SystemHand.Count);
			Assert.AreEqual(2, game.PlayerHand.Count);
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Bet));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Deal));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Hit));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Stand));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Split));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Insurance));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.EvenMoney));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Surrender));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.DoubleDown));
		}

		[TestMethod]
		public void Scenario01_BBN()
		{
			BlackjackGame game = new BlackjackGame();
			game.Bet();
			game.Shoe.Stack("AS", 0);
			game.Shoe.Stack("AD", 1);
			game.Shoe.Stack("KC", 2);
			game.Shoe.Stack("TD", 3);
			game.Deal();
			Assert.AreEqual(2, game.SystemHand.Count);
			Assert.AreEqual(2, game.PlayerHand.Count);
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Bet));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Deal));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Hit));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Stand));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Split));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Insurance));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.EvenMoney));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Surrender));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.DoubleDown));
			Assert.AreEqual("blackjack", game.PlayerHand.Text);
			Assert.AreEqual("blackjack", game.SystemHand.Text);
		}

		[TestMethod]
		public void Scenario02_BBAN()
		{
			BlackjackGame game = new BlackjackGame();
			game.Bet();
			game.Shoe.Stack("AS", 0);
			game.Shoe.Stack("AD", 3);
			game.Shoe.Stack("KC", 2);
			game.Shoe.Stack("TD", 1);
			game.Deal();
			Assert.AreEqual(2, game.SystemHand.Count);
			Assert.AreEqual(2, game.PlayerHand.Count);
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Bet));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Deal));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Hit));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Stand));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Split));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Insurance));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.EvenMoney));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Surrender));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.DoubleDown));
			Assert.AreEqual("blackjack", game.PlayerHand.Text);
			game.Stand();
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Bet));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Deal));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Hit));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Stand));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Split));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Insurance));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.EvenMoney));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Surrender));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.DoubleDown));
			Assert.AreEqual("21 lost", game.PlayerHand.Text);
			Assert.AreEqual("blackjack", game.SystemHand.Text);
		}

		[TestMethod]
		public void Scenario03_BBAE()
		{
			BlackjackGame game = new BlackjackGame();
			game.Bet();
			game.Shoe.Stack("AS", 0);
			game.Shoe.Stack("AD", 3);
			game.Shoe.Stack("KC", 2);
			game.Shoe.Stack("TD", 1);
			game.Deal();
			Assert.AreEqual(2, game.SystemHand.Count);
			Assert.AreEqual(2, game.PlayerHand.Count);
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Bet));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Deal));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Hit));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Stand));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Split));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Insurance));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.EvenMoney));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Surrender));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.DoubleDown));
			Assert.AreEqual("blackjack", game.PlayerHand.Text);
			game.EvenMoney();
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Bet));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Deal));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Hit));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Stand));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Split));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Insurance));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.EvenMoney));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Surrender));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.DoubleDown));
			Assert.AreEqual("Even Money", game.PlayerHand.Text);
			Assert.AreEqual("Even Money", game.SystemHand.Text);
		}

		[TestMethod]
		public void Scenario04_BNN()
		{
			BlackjackGame game = null;
			do
			{
				game = new BlackjackGame();
				game.Bet();
				game.Shoe.Stack("AS", 0);
				game.Shoe.Stack("KC", 2);
				game.Deal();
			} while ((game.SystemHand.Score == 21) || (game.PlayerHand.Score != 21) ||
					(game.SystemHand[1].Rank == PlayingCard.Ace));
			Assert.AreEqual(2, game.SystemHand.Count);
			Assert.AreEqual(2, game.PlayerHand.Count);
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Bet));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Deal));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Hit));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Stand));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Split));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Insurance));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.EvenMoney));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Surrender));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.DoubleDown));
			Assert.AreEqual("blackjack", game.PlayerHand.Text);
			Assert.AreEqual(game.SystemHand.Score.ToString(), game.SystemHand.Text);
		}

		[TestMethod]
		public void Scenario05_BNAN()
		{
			BlackjackGame game = null;
			do
			{
				game = new BlackjackGame();
				game.Bet();
				game.Shoe.Stack("AS", 0);
				game.Shoe.Stack("KC", 2);
				game.Shoe.Stack("AC", 3);
				game.Deal();
			} while (game.SystemHand.Score == 21);
			Assert.AreEqual(2, game.SystemHand.Count);
			Assert.AreEqual(2, game.PlayerHand.Count);
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Bet));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Deal));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Hit));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Stand));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Split));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Insurance));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.EvenMoney));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Surrender));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.DoubleDown));
			Assert.AreEqual("blackjack", game.PlayerHand.Text);
			game.Stand();
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Bet));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Deal));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Hit));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Stand));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Split));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Insurance));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.EvenMoney));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Surrender));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.DoubleDown));
		}

		[TestMethod]
		public void Scenario06_BNAE()
		{
			BlackjackGame game = null;
			do
			{
				game = new BlackjackGame();
				game.Bet();
				game.Shoe.Stack("AS", 0);
				game.Shoe.Stack("KC", 2);
				game.Shoe.Stack("AC", 3);
				game.Deal();
			} while (game.SystemHand.Score == 21);
			Assert.AreEqual(2, game.SystemHand.Count);
			Assert.AreEqual(2, game.PlayerHand.Count);
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Bet));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Deal));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Hit));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Stand));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Split));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Insurance));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.EvenMoney));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Surrender));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.DoubleDown));
			Assert.AreEqual("blackjack", game.PlayerHand.Text);
			game.EvenMoney();
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Bet));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Deal));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Hit));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Stand));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Split));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Insurance));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.EvenMoney));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Surrender));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.DoubleDown));
			Assert.AreEqual("Even Money", game.PlayerHand.Text);
			Assert.AreEqual("Even Money", game.SystemHand.Text);
		}

		[TestMethod]
		public void Scenario11_NXNHIT()
		{
			BlackjackGame game = null;
			do
			{
				game = new BlackjackGame();
				game.Bet();
				game.Deal();
			} while ((game.SystemHand.Score == 21) || (game.PlayerHand.Score == 21) ||
				(game.SystemHand[1].Rank == PlayingCard.Ace) ||
				(game.PlayerHand[0].Rank == game.PlayerHand[1].Rank));
			Assert.AreEqual(2, game.SystemHand.Count);
			Assert.AreEqual(2, game.PlayerHand.Count);
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Bet));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Deal));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Hit));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Stand));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Split));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Insurance));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.EvenMoney));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Surrender));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.DoubleDown));
			game.Hit();
		}

		[TestMethod]
		public void Scenario12_NXNSTN()
		{
			BlackjackGame game = null;
			do
			{
				game = new BlackjackGame();
				game.Bet();
				game.Deal();
			} while ((game.SystemHand.Score == 21) || (game.PlayerHand.Score == 21) ||
				(game.SystemHand[1].Rank == PlayingCard.Ace) ||
				(game.PlayerHand[0].Rank == game.PlayerHand[1].Rank));
			Assert.AreEqual(2, game.SystemHand.Count);
			Assert.AreEqual(2, game.PlayerHand.Count);
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Bet));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Deal));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Hit));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Stand));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Split));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Insurance));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.EvenMoney));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Surrender));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.DoubleDown));
			game.Stand();
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Bet));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Deal));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Hit));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Stand));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Split));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Insurance));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.EvenMoney));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Surrender));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.DoubleDown));
		}

		[TestMethod]
		public void Scenario13_NXNDBL()
		{
			BlackjackGame game = null;
			do
			{
				game = new BlackjackGame();
				game.Bet();
				game.Deal();
			} while ((game.SystemHand.Score == 21) || (game.PlayerHand.Score == 21) ||
				(game.SystemHand[1].Rank == PlayingCard.Ace) ||
				(game.PlayerHand[0].Rank == game.PlayerHand[1].Rank));
			Assert.AreEqual(2, game.SystemHand.Count);
			Assert.AreEqual(2, game.PlayerHand.Count);
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Bet));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Deal));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Hit));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Stand));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Split));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Insurance));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.EvenMoney));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Surrender));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.DoubleDown));
			game.DoubleDown();
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Bet));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Deal));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Hit));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Stand));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Split));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Insurance));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.EvenMoney));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Surrender));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.DoubleDown));
		}

		[TestMethod]
		public void Scenario14_NXNSUR()
		{
			BlackjackGame game = null;
			do
			{
				game = new BlackjackGame();
				game.Bet();
				game.Deal();
			} while ((game.SystemHand.Score == 21) || (game.PlayerHand.Score == 21) ||
				(game.SystemHand[1].Rank == PlayingCard.Ace) ||
				(game.PlayerHand[0].Rank == game.PlayerHand[1].Rank));
			Assert.AreEqual(2, game.SystemHand.Count);
			Assert.AreEqual(2, game.PlayerHand.Count);
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Bet));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Deal));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Hit));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Stand));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Split));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Insurance));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.EvenMoney));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Surrender));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.DoubleDown));
			game.Surrender();
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Bet));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Deal));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Hit));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Stand));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Split));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Insurance));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.EvenMoney));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Surrender));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.DoubleDown));
		}

		[TestMethod]
		public void Scenario15_NXAINS()
		{
			BlackjackGame game = null;
			do
			{
				game = new BlackjackGame();
				game.Bet();
				game.Shoe.Stack("AS", 3);
				game.Deal();
			} while ((game.SystemHand.Score == 21) || (game.PlayerHand.Score == 21) ||
				(game.PlayerHand[0].Rank == game.PlayerHand[1].Rank));
			Assert.AreEqual(2, game.SystemHand.Count);
			Assert.AreEqual(2, game.PlayerHand.Count);
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Bet));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Deal));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Hit));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Stand));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Split));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Insurance));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.EvenMoney));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Surrender));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.DoubleDown));
			game.Insurance();
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Bet));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Deal));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Hit));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Stand));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Split));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Insurance));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.EvenMoney));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Surrender));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.DoubleDown));
		}

		[TestMethod]
		public void Scenario16_NXPSPL()
		{
			BlackjackGame game = null;
			do
			{
				game = new BlackjackGame();
				game.Bet();
				game.Deal();
			} while ((game.SystemHand.Score == 21) || (game.PlayerHand.Score == 21) ||
				(game.SystemHand[1].Rank == PlayingCard.Ace) ||
				(game.PlayerHand[0].Rank != game.PlayerHand[1].Rank) ||
				(game.PlayerHand[0].Rank >= 10));
			Assert.AreEqual(2, game.SystemHand.Count);
			Assert.AreEqual(2, game.PlayerHand.Count);
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Bet));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Deal));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Hit));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Stand));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Split));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.Insurance));
			Assert.IsTrue(!game.OpAvailable(BlackjackOp.EvenMoney));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.Surrender));
			Assert.IsTrue(game.OpAvailable(BlackjackOp.DoubleDown));
			game.Split();
		}
	}
}
