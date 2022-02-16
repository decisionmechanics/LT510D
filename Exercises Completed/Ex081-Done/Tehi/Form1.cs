namespace Tehi
{
    using CardLib;
    using TehiEntities;

    public partial class Form1 : Form
    {
        private TehiGame game = new TehiGame();

        public Form1()
        {
            InitializeComponent();
        }

        private void SwapCard(int ix)
        {
            game.SwapCard(ix);
            ShowOutput();

            StatusLabel.Text = "Swap button " + ix + " pressed.";
        }

        private void DealButton_Click(object sender, EventArgs e)
        {
            game.Deal();

            ShowOutput();
        }

        private void ShowOutput()
        {
            LogListBox.Items.Clear();

            LogListBox.Items.Add(game.ToString());

            foreach (PlayingCard card in this.game)
            {
                LogListBox.Items.Add(card.ToString());
            }

            PictureBox[] images = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5 };
            Button[] swapButtons = { SwapButton0, SwapButton1, SwapButton2, SwapButton3, SwapButton4 };

            for (int i = 0; i < game.Count(); i++)
            {
                PaintCard(images[i], game.ElementAt(i));
                swapButtons[i].Enabled = game.CanSwapCards;
            }

            LogListBox.Items.Add("Score: " + game.Score);
            LogListBox.Items.Add("Best Hand Score: " + game.BestHandScore);
            LogListBox.Items.Add("Hands Dealt: " + game.HandsDealt);
        }

        private void PaintCard(PictureBox image, PlayingCard card)
        {
            image.Visible = true;
            int ix = card.Index;
            image.Image = PlayingCardImageList.Images[ix];
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogListBox.Items.Clear();

            StatusLabel.Text = string.Empty;

            PictureBox[] images = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5 };

            foreach (PictureBox box in images)
            {
                box.Visible = false;
            }

            Button[] swapButtons = { SwapButton0, SwapButton1, SwapButton2, SwapButton3, SwapButton4 };

            foreach (Button swapButton in swapButtons)
            {
                swapButton.Enabled = false;
            }

            game = new TehiGame();
        }

        private void top10ToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            LogListBox.Items.Clear();

            DataAccessor da = new DataAccessor();

            foreach (Player p in da.Top10Players)
            {
                LogListBox.Items.Add($"{p.Name} {p.BestHandScore} {p.HandsDealt}");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Learning Tree International", "About");
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = "Lging button was pressed";
        }

        private void SwapButton0_Click(object sender, EventArgs e)
        {
            SwapCard(0);
        }

        private void SwapButton1_Click(object sender, EventArgs e)
        {
            SwapCard(1);
        }

        private void SwapButton2_Click(object sender, EventArgs e)
        {
            SwapCard(2);
        }

        private void SwapButton3_Click(object sender, EventArgs e)
        {
            SwapCard(3);
        }

        private void SwapButton4_Click(object sender, EventArgs e)
        {
            SwapCard(4);
        }

        private void tableColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog(this);
            if (result == DialogResult.Cancel) return;

            BackColor = colorDialog1.Color;
        }

        private void resetDefaultColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }
    }
}