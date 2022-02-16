using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CardLib;

namespace Blackjack
{
	public partial class DeckStackingForm : Form,IComparer<string>
	{
		private PictureBox[] pickImages;
		private PictureBox[] deckImages;
		private CardDeck deck;
#pragma warning disable CS3003
		public CardDeck DeckToStack
		{
			get { return deck; }
			set { deck = value; }
		}
#pragma warning restore CS3003
		private List<string> pickCards = new List<string>();
		private List<int> undoList = new List<int>();
		private int maxDeckCards;
		private string[] stacking;
		public string Stacking(int index) { return stacking[index]; }
		public int StackingLength { get { return stacking.Length; } }

		public DeckStackingForm()
		{
			InitializeComponent();
			pickImages = new PictureBox[]
			{
				pictureBox1,  pictureBox2,  pictureBox3,  pictureBox4,  pictureBox5,  pictureBox6,  pictureBox7,  pictureBox8,  pictureBox9,  pictureBox10,
				pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20,
				pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25, pictureBox26, pictureBox27, pictureBox28, pictureBox29, pictureBox30,
				pictureBox31, pictureBox32, pictureBox33, pictureBox34, pictureBox35, pictureBox36, pictureBox37, pictureBox38, pictureBox39, pictureBox40,
				pictureBox41, pictureBox42, pictureBox43, pictureBox44, pictureBox45, pictureBox46, pictureBox47, pictureBox48, pictureBox49, pictureBox50,
				pictureBox51, pictureBox52, pictureBox53, pictureBox54, pictureBox55, pictureBox56, pictureBox57, pictureBox58, pictureBox59, pictureBox60
			};
			deckImages = new PictureBox[]
			{
				pictureBox61, pictureBox62, pictureBox63, pictureBox64, pictureBox65, pictureBox66, pictureBox67, pictureBox68, pictureBox69, pictureBox70,
				pictureBox71, pictureBox72, pictureBox73, pictureBox74, pictureBox75, pictureBox76, pictureBox77, pictureBox78, pictureBox79, pictureBox80,
				pictureBox81, pictureBox82, pictureBox83, pictureBox84, pictureBox85, pictureBox86, pictureBox87, pictureBox88, pictureBox89, pictureBox90,
				pictureBox91, pictureBox92, pictureBox93, pictureBox94, pictureBox95, pictureBox96, pictureBox97, pictureBox98, pictureBox99, pictureBox100,
				pictureBox101,pictureBox102,pictureBox103,pictureBox104,pictureBox105,pictureBox106,pictureBox107,pictureBox108,pictureBox109,pictureBox110,
				pictureBox111,pictureBox112,pictureBox113,pictureBox114,pictureBox115,pictureBox116,pictureBox117,pictureBox118,pictureBox119,pictureBox120
			};
		}

		private void DeckStackingForm_Load(object sender, EventArgs e)
		{
			if ((deck == null) || (deck.Count == 0)) deck = new CardDeck();

			undoList.Clear();
			btnUndo.Visible = false;
			maxDeckCards = deck.Count;
			pickCards.Clear();
			foreach (PlayingCard card in deck) if (!pickCards.Contains(card.Code)) pickCards.Add(card.Code);
			DisplayPickCards();
			for (int i = 0; i < deckImages.Length; i++)
			{
				if (i < maxDeckCards) EnableDragTarget(i);
				else DisableDragTarget(i);
			}
			btnRedo.Visible = AllCardsFromPreviousStackingAreAvailable();
		}

		private void DisableDragTarget(int ix)
		{
			PictureBox box = deckImages[ix];
			box.Image = null;
			box.Tag = string.Empty;
			box.DragEnter -= deckImage_DragEnter;
			box.DragDrop -= deckImage_DragDrop;
			box.AllowDrop = false;
			box.Visible = false;
		}

		private void EnableDragTarget(int ix)
		{
			PictureBox box = deckImages[ix];
			box.Image = null;
			box.Tag = string.Empty;
			box.DragEnter += deckImage_DragEnter;
			box.DragDrop += deckImage_DragDrop;
			box.AllowDrop = true;
			box.Visible = true;
		}

		private void DisplayPickCards()
		{
			pickCards.Sort(this);
			for (int i = 0; i < pickImages.Length; i++)
			{
				if (i >= pickCards.Count)
				{
					pickImages[i].MouseDown -= pickImage_MouseDown;
					pickImages[i].Image = null;
					pickImages[i].Visible = false;
				}
				else
				{
					string cardCode = pickCards[i];
					pickImages[i].Tag = cardCode;
					pickImages[i].Image = LoadCardImage(cardCode);
					pickImages[i].MouseDown += pickImage_MouseDown;
					pickImages[i].Visible = true;
				}
			}
		}

		private Image LoadCardImage(string cardCode)
		{
			PlayingCard card = PlayingCard.Parse(cardCode);
			card.FaceUp = true;
			return playingCardImageListSmall.Images[card.ImageIndex];
		}

		private void pickImage_MouseDown(object sender, MouseEventArgs e)
		{
			PictureBox box = (PictureBox)sender;
			box.DoDragDrop(box.Tag.ToString(), DragDropEffects.Copy);
		}

		private void deckImage_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.Text))
			{
				e.Effect = DragDropEffects.Copy;
			}
		}

		private void deckImage_DragDrop(object sender, DragEventArgs e)
		{
			PictureBox box = (PictureBox)sender;
			string cardCode = (string)e.Data.GetData(DataFormats.Text);
			PlayingCard card = PlayingCard.Parse(cardCode);
			card.FaceUp = true;
			box.Image = playingCardImageListSmall.Images[card.ImageIndex];
			box.Tag = cardCode;
			box.AllowDrop = false;
			pickCards.Remove(cardCode);
			DisplayPickCards();
			for (int ix = 0; ix < maxDeckCards; ix++)
			{
				if (sender == deckImages[ix])
				{
					undoList.Add(ix);
					btnUndo.Visible = true;
					return;
				}
			}
		}

		private void btnUndo_Click(object sender, EventArgs e)
		{
			int ix = undoList[undoList.Count - 1];
			undoList.RemoveAt(undoList.Count - 1);
			PictureBox box = deckImages[ix];
			if (undoList.Count <= 0)
				btnUndo.Visible = false;
			string cardCode = (string) box.Tag;
			if (cardCode.Length == 0)
			{
				btnUndo.Visible = false;
				return;
			}
			if (!pickCards.Contains(cardCode)) pickCards.Add(cardCode);
			DisplayPickCards();
			box.Image = null;
			box.Tag = string.Empty;
			box.AllowDrop = true;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}

		private void btnStack_Click(object sender, EventArgs e)
		{
			stacking = new string[deck.Count];
			for (int i = 0; (i < stacking.Length) && (i < deckImages.Length); i++)
			{
				stacking[i] = (string) deckImages[i].Tag;
			}
			DialogResult = DialogResult.OK;
		}

		private void btnRedo_Click(object sender, EventArgs e)
		{
			btnRedo.Visible = false;
			if (!AllCardsFromPreviousStackingAreAvailable())
			{
				MessageBox.Show(this, "The previous stacking is not valid in this context.\nNot all the cards requested are in the deck.", "Stacking Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 0);
				return;
			}
			for (int i = 0; i < stacking.Length; i++)
			{
				string cardCode = stacking[i];
				PictureBox box = deckImages[i];
				if (cardCode.Length != 0)
				{
					PlayingCard card = PlayingCard.Parse(cardCode);
					card.FaceUp = true;
					box.Image = playingCardImageListSmall.Images[card.ImageIndex];
					box.Tag = cardCode;
					box.AllowDrop = false;
					pickCards.Remove(cardCode);
					DisplayPickCards();
					undoList.Add(i);
					btnUndo.Visible = true;
				}
			}
		}

		private bool AllCardsFromPreviousStackingAreAvailable()
		{
			if ((stacking == null) || NoCardsWereStacked()) return false;
			foreach (string s in stacking)
			{
				if (s == null) return false;
				if ((s.Length != 0) && !pickCards.Contains(s)) return false;
			}
			return true;
		}

		private bool NoCardsWereStacked()
		{
			foreach (string s in stacking) if (s.Length != 0) return false;
			return true;
		}

		public int Compare(string x, string y)
		{
			if (x == null) throw new ArgumentNullException("x");
			if (y == null) throw new ArgumentNullException("y");
			if ((x.Length == 0) || (y.Length == 0)) return string.Compare(x, y);
			return string.Compare(Collate(x), Collate(y));
		}

		private static string Collate(string original)
		{
			if (original == null) throw new ArgumentNullException("original");
			if (EqualStrings(original,"AS")) return "1S";
			if (EqualStrings(original,"AH")) return "1H";
			if (EqualStrings(original, "AD")) return "1D";
			if (EqualStrings(original, "AC")) return "1C";
			if (EqualStrings(original, "TS")) return "BS";
			if (EqualStrings(original, "TH")) return "BH";
			if (EqualStrings(original, "TD")) return "BD";
			if (EqualStrings(original, "TC")) return "BC";
			if (EqualStrings(original, "KS")) return "XS";
			if (EqualStrings(original, "KH")) return "XH";
			if (EqualStrings(original, "KD")) return "XD";
			if (EqualStrings(original, "KC")) return "XC";
			return original;
		}

		private static bool EqualStrings(string s1, string s2)
		{
			return (string.Compare(s1,s2,true) == 0);
		}
	}
}