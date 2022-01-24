using System;

using System.Windows.Forms;
using CardLib;

namespace Blackjack
{
	public partial class OtherPreferencesDialog : Form
	{
		CardDeck deck;
		public OtherPreferencesDialog(CardDeck deck)
		{
			InitializeComponent();
			this.deck = deck;
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			if (deck == null) return;
		}

		private void btnSelect_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}
	}
}
