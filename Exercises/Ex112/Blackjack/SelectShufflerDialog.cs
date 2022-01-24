using System;

using System.Windows.Forms;
using CardLib;

namespace Blackjack
{
	public partial class SelectShufflerDialog : Form
	{
		CardDeck deck;
		public SelectShufflerDialog(CardDeck deck)
		{
			InitializeComponent();
			this.deck = deck;
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			if (deck == null) return;
			ddlSelectShuffler.Items.Add("Knuth Shuffler");
			ddlSelectShuffler.Items.Add("Modified Knuth Shuffler");
		}
		private void btnSelect_Click(object sender, EventArgs e)
		{
			switch (ddlSelectShuffler.SelectedIndex)
			{
				case 0: { deck.ChangeShuffler(new KnuthShuffler()); break; }
				case 1: { deck.ChangeShuffler(new ModifiedKnuthShuffler()); break; }
			}
			this.Dispose();
		}
	}
}
