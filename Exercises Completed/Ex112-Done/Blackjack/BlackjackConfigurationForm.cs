using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CardLib;

namespace Blackjack
{
	public partial class BlackjackConfigurationForm : Form
	{
		private BlackjackConfiguration config = BlackjackConfiguration.Instance;
		public BlackjackConfigurationForm()
		{
			InitializeComponent();
		}

		private void BlackjackConfigurationForm_Load(object sender, EventArgs e)
		{
			if (BlackjackConfiguration.HasBeenSaved) config.Load();
			LoadFormElements();
		}

		private void LoadFormElements()
		{
			rbDealerDrawsOnSoft17.Checked = config.Data.DealerDrawsOnSoft17;
			rbDealerStandsOn17.Checked = !config.Data.DealerDrawsOnSoft17;

			rbDealerPaidOnTies.Checked = config.Data.PayDealerOnTie;
			rbTiedHandsAreAPush.Checked = !config.Data.PayDealerOnTie;

			if (config.Data.PayoffOnBlackjack == 1.5)
			{
				rbBlackJackPays3to2.Checked = true;
				rbBlackjackPaysEvenMoney.Checked = false;
			}
			else
			{
				rbBlackJackPays3to2.Checked = false;
				rbBlackjackPaysEvenMoney.Checked = true;
			}

			rbInsuranceNotAllowed.Checked = true; //!(BlackjackConfig.InsuranceAllowed && BlackjackConfig.OnlyEvenMoneyAllowed);
			rbInsuranceAllowed.Checked = config.Data.InsuranceAllowed;
			rbOnlyEvenMoneyAllowed.Checked = config.Data.OnlyEvenMoneyAllowed;

			cbSurrenderAllowed.Checked = config.Data.SurrenderAllowed;

			RadioButton[] dis = { radioButton1, radioButton2, radioButton4 };
			foreach (RadioButton button in dis) button.Checked = false;
			if (config.Data.DecksInShoe == 1) radioButton1.Checked = true;
			if (config.Data.DecksInShoe == 2) radioButton2.Checked = true;
			if (config.Data.DecksInShoe == 4) radioButton4.Checked = true;

			cbCanSplitOn10sAllowed.Checked = config.Data.CanSplitOn10s;
			rbMax4HandsFromAnySplit.Checked = false;
			rbMax2HandsFromAnySplit.Checked = false;
			rbMax4HandsFromSplitButOnly2FromAces.Checked = false;
			if ((config.Data.MaximumSplitsOnAces == 4) && (config.Data.MaximumSplitsOnNonAces == 4))
			{
				rbMax4HandsFromAnySplit.Checked = true;
			}
			else if ((config.Data.MaximumSplitsOnAces == 2) && (config.Data.MaximumSplitsOnNonAces == 4))
			{
				rbMax4HandsFromSplitButOnly2FromAces.Checked = true;
			}
			else rbMax2HandsFromAnySplit.Checked = true;

			rbBet2To20.Checked = false;
			rbBet5To50.Checked = false;
			rbBet10to100.Checked = false;
			if ((config.Data.BetIncrement == 2) && (config.Data.MaximumBet == 20))
				rbBet2To20.Checked = true;
			if ((config.Data.BetIncrement == 5) && (config.Data.MaximumBet == 50))
				rbBet5To50.Checked = true;
			if ((config.Data.BetIncrement == 10) && (config.Data.MaximumBet == 100))
				rbBet10to100.Checked = true;

			rbDealerGets1Card.Checked = config.Data.DealerGetsASingleUpCardOnFirstDeal;
			rbDealerGets2cards.Checked = !rbDealerGets1Card.Checked;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			config.Data.DealerDrawsOnSoft17 = rbDealerDrawsOnSoft17.Checked;
			config.Data.PayDealerOnTie = rbDealerPaidOnTies.Checked;
			config.Data.PayoffOnBlackjack = 1.5;
			if (rbBlackjackPaysEvenMoney.Checked) config.Data.PayoffOnBlackjack = 1.0;
			config.Data.InsuranceAllowed = rbInsuranceAllowed.Checked;
			config.Data.OnlyEvenMoneyAllowed = rbOnlyEvenMoneyAllowed.Checked;
			config.Data.SurrenderAllowed = cbSurrenderAllowed.Checked;

			if (radioButton1.Checked) config.Data.DecksInShoe = 1;
			if (radioButton2.Checked) config.Data.DecksInShoe = 2;
			if (radioButton4.Checked) config.Data.DecksInShoe = 4;

			config.Data.CanSplitOn10s = cbCanSplitOn10sAllowed.Checked;
			if (rbMax4HandsFromAnySplit.Checked)
			{
				config.Data.MaximumSplitsOnAces = 4;
				config.Data.MaximumSplitsOnNonAces = 4;
			}
			else if (rbMax2HandsFromAnySplit.Checked)
			{
				config.Data.MaximumSplitsOnAces = 2;
				config.Data.MaximumSplitsOnNonAces = 2;
			}
			else if (rbMax4HandsFromSplitButOnly2FromAces.Checked)
			{
				config.Data.MaximumSplitsOnAces = 2;
				config.Data.MaximumSplitsOnNonAces = 4;
			}

			if (rbBet10to100.Checked)
			{
				config.Data.MaximumBet = 100;
				config.Data.BetIncrement = 10;
			}
			else if (rbBet2To20.Checked)
			{
				config.Data.MaximumBet = 20;
				config.Data.BetIncrement = 2;
			}
			if (rbBet5To50.Checked)
			{
				config.Data.MaximumBet = 50;
				config.Data.BetIncrement = 5;
			}

			config.Data.DealerGetsASingleUpCardOnFirstDeal = rbDealerGets1Card.Checked;

			config.Save();
			this.DialogResult = DialogResult.OK;
			this.Dispose();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			config.ResetDefaults();
			LoadFormElements();
		}

		private void button6_Click(object sender, EventArgs e)
		{	// Las Vegas
			config.ResetDefaults();
			config.Data.InsuranceAllowed = false;
			config.Data.OnlyEvenMoneyAllowed = true;
			config.Data.DecksInShoe = 8;
			LoadFormElements();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			config.ResetDefaults();
			config.Data.PayDealerOnTie = false;
			config.Data.DealerDrawsOnSoft17 = true;
			config.Data.PayoffOnBlackjack = 1.0;
			config.Data.MaximumBet = 20;
			config.Data.BetIncrement = 2;
			LoadFormElements();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			config.ResetDefaults();
			config.Data.DealerGetsASingleUpCardOnFirstDeal = true;
			config.Data.DealerDrawsOnSoft17 = true;
			config.Data.PayoffOnBlackjack = 1.0;
			config.Data.SurrenderAllowed = false;
			config.Data.CanSplitOn10s = true;
			LoadFormElements();
		}
	}
}