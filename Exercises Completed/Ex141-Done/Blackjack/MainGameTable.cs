#region Referenced Namespaces
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using CardLib;
#endregion

namespace Blackjack
{
	public partial class MainGameTable : Form
	{
		#region Fields

		private DateTime colorChangeStarted;
		private Form activeForm;
		private PreferenceProfile prefs = new PreferenceProfile();
		DeckStackingForm stackDeckDialog = new DeckStackingForm();

		#endregion
		#region Constructor and form initialization

		public MainGameTable()
		{
			InitializeComponent();
		}

		private void MainGameTable_Load(object sender, EventArgs e)
		{
			StartBlackjack();
		}
		#endregion
		#region Code to change the table's background color

		private void changeBackColorMenuItem_Click(object sender, EventArgs e) { SetTableColor(); }
		private void toolStripButton3_Click(object sender, EventArgs e) { SetTableColor(); }
		private void SetTableColor()
		{
			DialogResult dr = colorDialog1.ShowDialog(this);
			if (dr != DialogResult.OK) return;
			if (activeForm == null)
			{
				prefs.BackColor = colorDialog1.Color;
				prefs.SavePreferences();
			}
			else
			{
				colorChangeStarted = DateTime.Now;
				tableColorToolStripMenuItem.Enabled = false;
				colorFadeTimer.Start();
			}
		}
		private void resetDefaultBackColorMenuItem_Click(object sender, EventArgs e)
		{
			prefs.ResetDefaultPreferences(activeForm);
		}
		private void colorFadeTimer_Tick(object sender, EventArgs e)
		{
			if (activeForm == null)
			{
				colorFadeTimer.Stop();
				tableColorToolStripMenuItem.Enabled = true;
				return;
			}
			TimeSpan elapsed = DateTime.Now - colorChangeStarted;
			TimeSpan secondsAllowed = new TimeSpan(0, 0, 15);
			if ((elapsed >= secondsAllowed) ||
				(activeForm.BackColor == colorDialog1.Color))
			{
				colorFadeTimer.Stop();
				prefs.BackColor = colorDialog1.Color;
				prefs.SetPreferences(activeForm);
				activeForm.BackColor = colorDialog1.Color;
				tableColorToolStripMenuItem.Enabled = true;
				return;
			}
			int r = activeForm.BackColor.R;
			int g = activeForm.BackColor.G;
			int b = activeForm.BackColor.B;
			if (r < colorDialog1.Color.R) r++;
			if (r > colorDialog1.Color.R) r--;
			if (g < colorDialog1.Color.G) g++;
			if (g > colorDialog1.Color.G) g--;
			if (b < colorDialog1.Color.B) b++;
			if (b > colorDialog1.Color.B) b--;
			activeForm.BackColor = Color.FromArgb(r, g, b);
		}

		#endregion
		#region Misc. menu item and tool strip button processing

		private void aboutMenuItem_Click(object sender, EventArgs e) { ShowHelpAbout(); }

		private void toolStripButton5_Click(object sender, EventArgs e) { ShowHelpAbout(); }

		private void ShowHelpAbout()
		{
			MessageBox.Show(this, "Blackjack\nAn example of MVC with state pattern\nGreg says 'have fun, learn strategy, go play for real!'", "About Blackjack", MessageBoxButtons.OK, MessageBoxIcon.Information, 0);
		}

		private void exitMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void stopGameButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		#endregion
		#region Game selection menu items and support routines

		// New Game
		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			AbortCurrentGame();
			StartBlackjack();
		}

		private void blackjackMenuItem_Click(object sender, EventArgs e) { StartBlackjack(); }
		private void blackjackButton_Click(object sender, EventArgs e) { StartBlackjack(); }
		private void StartBlackjack() { StartGame(new BlackjackForm(this), 800, 730); }
		
		private void StartGame(Form form, int xSize, int ySize)
		{
			AbortCurrentGame();
			this.Size = new Size(xSize, ySize);
			DisplayForm(form);
		}

		private void AbortCurrentGame()
		{
			if (activeForm != null) activeForm.Dispose();
			activeForm = null;
			StatusLabel.Text = "";
		}

		private void DisplayForm(Form form)
		{
			activeForm = form;
			activeForm.MdiParent = this;
			activeForm.Show();
			activeForm.Dock = DockStyle.Fill;
			prefs.LoadPreferences(activeForm);
		}

		#endregion
		#region Game options and configurations menu items

		private void blackjackConfigMenuItem_Click(object sender, EventArgs e) { ConfigureGame(); }
		private void toolStripButton4_Click(object sender, EventArgs e) { ConfigureGame(); }
		private void ConfigureGame()
		{
			BlackjackConfigurationForm form = new BlackjackConfigurationForm();
			DialogResult result = form.ShowDialog(this);
			if (result == DialogResult.Cancel) return;
			if (activeForm == null) return;
			if (activeForm is BlackjackForm) StartBlackjack();
		}
		private void otherGamePreferencesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if ((activeForm == null) || !(activeForm is IStackable))
			{
				MessageBox.Show(this, "Changing other properties can only be done when a game is active.", "Shuffler Selection",
					MessageBoxButtons.OK, MessageBoxIcon.Error, 0);
				return;
			}
			IStackable form = (IStackable)activeForm;
			CardDeck deck = form.DeckToStack;
			SelectShufflerDialog dialog = new SelectShufflerDialog(deck);
			dialog.ShowDialog(this);
		}
		#endregion
		#region Deck stacking support

		private void stackTheDeckToolStripMenuItem_Click(object sender, EventArgs e) { StackDeck(); }
		private void toolStripButton1_Click(object sender, EventArgs e) { StackDeck(); }

		private void StackDeck()
		{
			if ((activeForm == null) || !(activeForm is IStackable))
			{
				MessageBox.Show(this, "Stacking the deck can only be done when a game is active\nand only if the game supports stacking the deck.", "Deck Stacking", MessageBoxButtons.OK, MessageBoxIcon.Error, 0);
				return;
			}
			IStackable form = (IStackable)activeForm;
			prefs.LoadPreferences(stackDeckDialog);
			stackDeckDialog.DeckToStack = form.DeckToStack;
			DialogResult result = stackDeckDialog.ShowDialog(this);
			if (result == DialogResult.Cancel) return;
			for (int i = 0; i < stackDeckDialog.StackingLength; i++)
				form.Stack(stackDeckDialog.Stacking(i), i);
		}

		#endregion
		#region Deal Testing Support
		private DealTester tester;
		private async void dealTestingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			dealTestingToolStripMenuItem.Enabled = false;
			StatusLabel.Text = "Deal tester started";
			tester = new DealTester(5000000);
			Action deal = new Action(tester.Deal);
			await Task.Run(deal);
			//tester.Deal();
			StatusLabel.Text = "Accuracy is " + (tester.Average * 4) + "%";
			StatusLabel.Visible = true;
			dealTestingToolStripMenuItem.Enabled = true;
		}
		#endregion
	}
}