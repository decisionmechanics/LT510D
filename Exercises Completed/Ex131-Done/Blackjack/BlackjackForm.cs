using System;
using System.Drawing;
using System.Windows.Forms;
using CardLib;

namespace Blackjack
{
	public partial class BlackjackForm : Form, IStackable
	{
		private const int iph = 15; // Images per hand
		private BlackjackGame game = new BlackjackGame();
		private Button[] buttons;
		private MainGameTable mainForm;
		private PictureBox[] dealerImages;
		private PictureBox[] playerImages;
		private Label[] playerTextLabels;
		private Button[] movingButtons;
		private Point[] splitButtonPositions;
		private Label[] plaqueLabels;
		private PictureBox[] sideImages;
		private BlackjackConfiguration config;

		public BlackjackForm(MainGameTable mainForm)
		{
			config = BlackjackConfiguration.Instance;
			if (BlackjackConfiguration.HasBeenSaved) config.Load();
			InitializeComponent();
			this.mainForm = mainForm;
			buttons = new Button[] { this.btnBetOneCredit, button2, btnHit, btnStand, btnSplit, btnInsure, btnEvenMoney, btnSurrender, btnDoubleDown};
			dealerImages = new PictureBox[] { pictureBox1,pictureBox2,pictureBox3,pictureBox4,pictureBox5,pictureBox6,pictureBox7,pictureBox8,pictureBox9,pictureBox10,pictureBox11,pictureBox12,pictureBox13,pictureBox14,pictureBox15};
			playerImages = new PictureBox[] { pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25, pictureBox26, pictureBox27, pictureBox28, pictureBox29, pictureBox30,
											  pictureBox45, pictureBox44, pictureBox43, pictureBox42, pictureBox41, pictureBox40, pictureBox39, pictureBox38, pictureBox37, pictureBox36, pictureBox35, pictureBox34, pictureBox33, pictureBox32, pictureBox31,
											  pictureBox60, pictureBox59, pictureBox58, pictureBox57, pictureBox56, pictureBox55, pictureBox54, pictureBox53, pictureBox52, pictureBox51, pictureBox50, pictureBox49, pictureBox48, pictureBox47, pictureBox46,
											  pictureBox75, pictureBox74, pictureBox73, pictureBox72, pictureBox71, pictureBox70, pictureBox69, pictureBox68, pictureBox67, pictureBox66, pictureBox65, pictureBox64, pictureBox63, pictureBox62, pictureBox61 };
			playerTextLabels = new Label[] { label8, label5, label6, label7 };
			sideImages = new PictureBox[] { 
				pictureBox76,pictureBox77,pictureBox78,pictureBox82,pictureBox81,
				pictureBox80,pictureBox79,pictureBox90,pictureBox89,pictureBox88,
				pictureBox87,pictureBox86,pictureBox85,pictureBox84,pictureBox83,
				pictureBox106,pictureBox105,pictureBox104,pictureBox103,pictureBox102,
				pictureBox101,pictureBox100,pictureBox99,pictureBox98,pictureBox97,
				pictureBox96,pictureBox95,pictureBox94,pictureBox93,pictureBox92,
				pictureBox91,pictureBox109,pictureBox110,
				pictureBox111,pictureBox112,pictureBox113,pictureBox114,pictureBox115,
				pictureBox116,pictureBox117,pictureBox118,pictureBox119,pictureBox120,
				pictureBox121,pictureBox122,pictureBox123,pictureBox124,pictureBox125,
				pictureBox126,pictureBox127,pictureBox128,pictureBox129,pictureBox130,
				pictureBox131,pictureBox132,pictureBox133,pictureBox134,pictureBox135,
				pictureBox136,pictureBox137,pictureBox138,pictureBox139,pictureBox140,
				pictureBox141,pictureBox142,pictureBox143,pictureBox144
			};
			splitButtonPositions = new Point[] {
				btnEvenMoney.Location, pictureBox45.Location,
				pictureBox60.Location, pictureBox75.Location
			};
			movingButtons = new Button[] { btnSplit, btnHit, btnStand };
			plaqueLabels = new Label[] {label9,label10,label11,label12,label13,label14, label15};
		}

		private void VideoBlackjackForm_Load(object sender, EventArgs e)
		{
			SetGameOptionsPlaque();
			foreach (PictureBox pb in dealerImages) pb.Size = new Size(71, 98);
			foreach (PictureBox pb in playerImages) pb.Size = new Size(71, 98);
			SideImage.Visible = false;
			for (int i = 0; i < sideImages.Length; i++)
			{
				sideImages[i].Visible = false;
				sideImages[i].Location = new Point(SideImage.Location.X, SideImage.Location.Y - (i*2));
			}
			DoOutput();
			game.StateChanged += OutputNeeded;
		}

		private void SetGameOptionsPlaque()
		{
			int lix = 0;

			if (config.Data.PayoffOnBlackjack == 1.5) plaqueLabels[lix++].Text = "Blackjack pays 3:2";
			else plaqueLabels[lix++].Text = "Blackjack pays even money";

			if (config.Data.PayDealerOnTie) plaqueLabels[lix++].Text = "Dealer paid on ties";
			else plaqueLabels[lix++].Text = "Tied hands push";

			if (config.Data.DealerDrawsOnSoft17) plaqueLabels[lix++].Text = "Dealer draws on soft 17";
			else plaqueLabels[lix++].Text = "Dealer stands on 17";

			if (config.Data.SurrenderAllowed) plaqueLabels[lix++].Text = "Surrender allowed";
			else plaqueLabels[lix++].Text = "No Surrender";

			if (config.Data.InsuranceAllowed) plaqueLabels[lix++].Text = "Insurance allowed";
			else if (config.Data.OnlyEvenMoneyAllowed) plaqueLabels[lix++].Text = "Even money allowed";
			else plaqueLabels[lix++].Text = "No Insurance or Even Money";

			if (config.Data.MaximumSplitsOnNonAces == 0) plaqueLabels[lix++].Text = "Splitting not allowed";
			else plaqueLabels[lix++].Text = "Max splits " + config.Data.MaximumSplitsOnNonAces;

			if (config.Data.MaximumSplitsOnAces == 0) plaqueLabels[lix++].Text = "Splitting not allowed on aces";
			else plaqueLabels[lix++].Text = "Max splits on aces " + config.Data.MaximumSplitsOnAces;
		}

		private void OutputNeeded(object sender, EventArgs e)
		{
			DoOutput();
		}

		private void DoOutput()
		{
			PaintHand(game.SystemHand,dealerImages,0);
			lblDealerText.Text = game.SystemHand.Text;

			int chix = game.CurrentPlayerHandIndex;
			Point a = splitButtonPositions[chix];
			int height = btnHit.Location.Y - btnSplit.Location.Y;
			for (int i = 0; i < movingButtons.Length; i++)
			{
				Point m = movingButtons[i].Location;
				movingButtons[i].Location = new Point(m.X,a.Y + (i * height));
			}
			for (int i = 0; i < playerImages.Length; i += iph)
			{
				int handIndex = i / iph;
				playerTextLabels[handIndex].Text = "";
				if (handIndex < game.NumberOfPlayerHands)
				{
					PaintHand(game.PlayerHands(handIndex), playerImages, i);
					playerTextLabels[handIndex].Text = game.PlayerHands(handIndex).Text;
				}
				else for (int j = i; j < i + iph; j++) playerImages[j].Visible = false;
			}

			for (int i = 0; i < buttons.Length; i++)
				buttons[i].Visible = game.OpAvailable((BlackjackOp)i);
			btnBetMaximum.Visible = game.OpAvailable(BlackjackOp.Bet);

			lblCredits.Text = game.Credits.ToString();
			lblBetAmount.Text = game.BetAmount.ToString();
			lblPaid.Text = game.BetPaid.ToString();
			//lblStacked.Visible = game.IsStacked;
			lblInsPaid.Text = game.InsurancePaid.ToString();
		}
		private void PaintHand(GameHand hand, PictureBox[] images, int startIndex)
		{
			for (int i = 0; i < iph; i++)
			{
				if (i < hand.Count)
				{
					images[startIndex+i].Image = mainForm.PlayingCardImageList.Images[hand[i].ImageIndex];
					images[startIndex+i].Visible = true;
				}
				else images[startIndex+i].Visible = false;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			game.Bet();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			game.Deal();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			game.Hit();
			DoOutput();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			game.Stand();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			game.Split();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			game.Insurance();
			DoOutput();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			game.EvenMoney();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			game.Surrender();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			game.DoubleDown();
		}

		private void button10_Click(object sender, EventArgs e)
		{
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			game.Bet();
		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			game.Deal();

			int cardsInDrop = (52 * config.Data.DecksInShoe) - game.Shoe.TotalCardsInShoe;
			int imagesInDrop = cardsInDrop / 4;
			SideImage.Visible = true;
			for (int i = 0; i < sideImages.Length; i++)
			{
				sideImages[i].Visible = (i < imagesInDrop);
				sideImages[i].Image = SideImage.Image;
				sideImages[i].BringToFront();
			}
			this.lblCardsLeftInShoe.Text = "" + game.Shoe.TotalCardsInShoe;
		}

		private void button3_Click_1(object sender, EventArgs e)
		{
			game.Hit();
		}

		private void button4_Click_1(object sender, EventArgs e)
		{
			game.Stand();
		}

		private void button8_Click_1(object sender, EventArgs e)
		{
			game.Surrender();
		}

		private void button7_Click_1(object sender, EventArgs e)
		{
			game.EvenMoney();
		}

		private void button9_Click_1(object sender, EventArgs e)
		{
			game.DoubleDown();
		}

		private void button5_Click_1(object sender, EventArgs e)
		{
			game.Split();
		}

		private void button10_Click_1(object sender, EventArgs e)
		{
			game = new BlackjackGame();
			DoOutput();
		}

		private void btnBetMaximum_Click(object sender, EventArgs e)
		{
			while (game.BetAmount < config.Data.MaximumBet) game.Bet();
		}

		#region IStackable Members

		public void Stack(string cardCode, int position)
		{
			game.Stack(cardCode, position);
			DoOutput();
		}
#pragma warning disable CS3003
		public CardDeck DeckToStack
		{
			get { return game.DeckToStack; }
		}
#pragma warning restore CS3003

		public bool IsStacked
		{
			get { return game.IsStacked; }
		}

		#endregion
	}
}