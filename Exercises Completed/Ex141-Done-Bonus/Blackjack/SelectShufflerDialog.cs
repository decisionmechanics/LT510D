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
			foreach (string choice in ShufflerFactory.Choices)
			{
				ddlSelectShuffler.Items.Add(choice);
			}
		}
		private void btnSelect_Click(object sender, EventArgs e)
		{
			IShuffler shuffler = ShufflerFactory.Create(ddlSelectShuffler.Text);
			if (shuffler != null) deck.ChangeShuffler(shuffler);
			this.Dispose();
		}
	}
}
