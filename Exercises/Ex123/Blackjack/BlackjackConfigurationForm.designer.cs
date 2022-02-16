namespace Blackjack
{
	partial class BlackjackConfigurationForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbDealerDrawsOnSoft17 = new System.Windows.Forms.RadioButton();
			this.rbDealerStandsOn17 = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rbBlackjackPaysEvenMoney = new System.Windows.Forms.RadioButton();
			this.rbBlackJackPays3to2 = new System.Windows.Forms.RadioButton();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.rbTiedHandsAreAPush = new System.Windows.Forms.RadioButton();
			this.rbDealerPaidOnTies = new System.Windows.Forms.RadioButton();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.cbSurrenderAllowed = new System.Windows.Forms.CheckBox();
			this.rbInsuranceNotAllowed = new System.Windows.Forms.RadioButton();
			this.rbInsuranceAllowed = new System.Windows.Forms.RadioButton();
			this.rbOnlyEvenMoneyAllowed = new System.Windows.Forms.RadioButton();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.cbCanSplitOn10sAllowed = new System.Windows.Forms.CheckBox();
			this.rbMax2HandsFromAnySplit = new System.Windows.Forms.RadioButton();
			this.rbMax4HandsFromAnySplit = new System.Windows.Forms.RadioButton();
			this.rbMax4HandsFromSplitButOnly2FromAces = new System.Windows.Forms.RadioButton();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.rbBet5To50 = new System.Windows.Forms.RadioButton();
			this.rbBet10to100 = new System.Windows.Forms.RadioButton();
			this.rbBet2To20 = new System.Windows.Forms.RadioButton();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.rbDealerGets1Card = new System.Windows.Forms.RadioButton();
			this.rbDealerGets2cards = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.groupBox8.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.rbDealerDrawsOnSoft17);
			this.groupBox1.Controls.Add(this.rbDealerStandsOn17);
			this.groupBox1.Location = new System.Drawing.Point(12, 52);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(311, 42);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dealer Draw";
			// 
			// rbDealerDrawsOnSoft17
			// 
			this.rbDealerDrawsOnSoft17.AutoSize = true;
			this.rbDealerDrawsOnSoft17.Location = new System.Drawing.Point(132, 19);
			this.rbDealerDrawsOnSoft17.Name = "rbDealerDrawsOnSoft17";
			this.rbDealerDrawsOnSoft17.Size = new System.Drawing.Size(137, 17);
			this.rbDealerDrawsOnSoft17.TabIndex = 5;
			this.rbDealerDrawsOnSoft17.TabStop = true;
			this.rbDealerDrawsOnSoft17.Text = "Dealer draws on soft 17";
			this.rbDealerDrawsOnSoft17.UseVisualStyleBackColor = true;
			// 
			// rbDealerStandsOn17
			// 
			this.rbDealerStandsOn17.AutoSize = true;
			this.rbDealerStandsOn17.Location = new System.Drawing.Point(6, 19);
			this.rbDealerStandsOn17.Name = "rbDealerStandsOn17";
			this.rbDealerStandsOn17.Size = new System.Drawing.Size(120, 17);
			this.rbDealerStandsOn17.TabIndex = 4;
			this.rbDealerStandsOn17.TabStop = true;
			this.rbDealerStandsOn17.Text = "Dealer stands on 17";
			this.rbDealerStandsOn17.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.button1.Location = new System.Drawing.Point(249, 432);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(74, 28);
			this.button1.TabIndex = 0;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.Location = new System.Drawing.Point(171, 432);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(74, 28);
			this.button2.TabIndex = 27;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.rbBlackjackPaysEvenMoney);
			this.groupBox2.Controls.Add(this.rbBlackJackPays3to2);
			this.groupBox2.Location = new System.Drawing.Point(12, 142);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(309, 42);
			this.groupBox2.TabIndex = 100;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Blackjack Payout";
			// 
			// rbBlackjackPaysEvenMoney
			// 
			this.rbBlackjackPaysEvenMoney.AutoSize = true;
			this.rbBlackjackPaysEvenMoney.Location = new System.Drawing.Point(130, 19);
			this.rbBlackjackPaysEvenMoney.Name = "rbBlackjackPaysEvenMoney";
			this.rbBlackjackPaysEvenMoney.Size = new System.Drawing.Size(158, 17);
			this.rbBlackjackPaysEvenMoney.TabIndex = 9;
			this.rbBlackjackPaysEvenMoney.TabStop = true;
			this.rbBlackjackPaysEvenMoney.Text = "Blackjack pays even money";
			this.rbBlackjackPaysEvenMoney.UseVisualStyleBackColor = true;
			// 
			// rbBlackJackPays3to2
			// 
			this.rbBlackJackPays3to2.AutoSize = true;
			this.rbBlackJackPays3to2.Location = new System.Drawing.Point(4, 19);
			this.rbBlackJackPays3to2.Name = "rbBlackJackPays3to2";
			this.rbBlackJackPays3to2.Size = new System.Drawing.Size(121, 17);
			this.rbBlackJackPays3to2.TabIndex = 8;
			this.rbBlackJackPays3to2.TabStop = true;
			this.rbBlackJackPays3to2.Text = "Blackjack pays 3 : 2";
			this.rbBlackJackPays3to2.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.rbTiedHandsAreAPush);
			this.groupBox3.Controls.Add(this.rbDealerPaidOnTies);
			this.groupBox3.Location = new System.Drawing.Point(12, 98);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(309, 41);
			this.groupBox3.TabIndex = 101;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Tied Hand Payout";
			// 
			// rbTiedHandsAreAPush
			// 
			this.rbTiedHandsAreAPush.AutoSize = true;
			this.rbTiedHandsAreAPush.Location = new System.Drawing.Point(132, 19);
			this.rbTiedHandsAreAPush.Name = "rbTiedHandsAreAPush";
			this.rbTiedHandsAreAPush.Size = new System.Drawing.Size(131, 17);
			this.rbTiedHandsAreAPush.TabIndex = 7;
			this.rbTiedHandsAreAPush.TabStop = true;
			this.rbTiedHandsAreAPush.Text = "Tied hands are a push";
			this.rbTiedHandsAreAPush.UseVisualStyleBackColor = true;
			// 
			// rbDealerPaidOnTies
			// 
			this.rbDealerPaidOnTies.AutoSize = true;
			this.rbDealerPaidOnTies.Location = new System.Drawing.Point(6, 19);
			this.rbDealerPaidOnTies.Name = "rbDealerPaidOnTies";
			this.rbDealerPaidOnTies.Size = new System.Drawing.Size(113, 17);
			this.rbDealerPaidOnTies.TabIndex = 6;
			this.rbDealerPaidOnTies.TabStop = true;
			this.rbDealerPaidOnTies.Text = "Dealer paid on ties";
			this.rbDealerPaidOnTies.UseVisualStyleBackColor = true;
			// 
			// groupBox4
			// 
			this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox4.Controls.Add(this.cbSurrenderAllowed);
			this.groupBox4.Controls.Add(this.rbInsuranceNotAllowed);
			this.groupBox4.Controls.Add(this.rbInsuranceAllowed);
			this.groupBox4.Controls.Add(this.rbOnlyEvenMoneyAllowed);
			this.groupBox4.Location = new System.Drawing.Point(12, 184);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(309, 56);
			this.groupBox4.TabIndex = 102;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Surrender and Insurance";
			// 
			// cbSurrenderAllowed
			// 
			this.cbSurrenderAllowed.AutoSize = true;
			this.cbSurrenderAllowed.Location = new System.Drawing.Point(4, 36);
			this.cbSurrenderAllowed.Name = "cbSurrenderAllowed";
			this.cbSurrenderAllowed.Size = new System.Drawing.Size(111, 17);
			this.cbSurrenderAllowed.TabIndex = 12;
			this.cbSurrenderAllowed.Text = "Surrender allowed";
			this.cbSurrenderAllowed.UseVisualStyleBackColor = true;
			// 
			// rbInsuranceNotAllowed
			// 
			this.rbInsuranceNotAllowed.AutoSize = true;
			this.rbInsuranceNotAllowed.Location = new System.Drawing.Point(130, 36);
			this.rbInsuranceNotAllowed.Name = "rbInsuranceNotAllowed";
			this.rbInsuranceNotAllowed.Size = new System.Drawing.Size(129, 17);
			this.rbInsuranceNotAllowed.TabIndex = 13;
			this.rbInsuranceNotAllowed.TabStop = true;
			this.rbInsuranceNotAllowed.Text = "Insurance not allowed";
			this.rbInsuranceNotAllowed.UseVisualStyleBackColor = true;
			// 
			// rbInsuranceAllowed
			// 
			this.rbInsuranceAllowed.AutoSize = true;
			this.rbInsuranceAllowed.Location = new System.Drawing.Point(4, 19);
			this.rbInsuranceAllowed.Name = "rbInsuranceAllowed";
			this.rbInsuranceAllowed.Size = new System.Drawing.Size(111, 17);
			this.rbInsuranceAllowed.TabIndex = 10;
			this.rbInsuranceAllowed.TabStop = true;
			this.rbInsuranceAllowed.Text = "Insurance allowed";
			this.rbInsuranceAllowed.UseVisualStyleBackColor = true;
			// 
			// rbOnlyEvenMoneyAllowed
			// 
			this.rbOnlyEvenMoneyAllowed.AutoSize = true;
			this.rbOnlyEvenMoneyAllowed.Location = new System.Drawing.Point(130, 19);
			this.rbOnlyEvenMoneyAllowed.Name = "rbOnlyEvenMoneyAllowed";
			this.rbOnlyEvenMoneyAllowed.Size = new System.Drawing.Size(146, 17);
			this.rbOnlyEvenMoneyAllowed.TabIndex = 11;
			this.rbOnlyEvenMoneyAllowed.TabStop = true;
			this.rbOnlyEvenMoneyAllowed.Text = "Only even money allowed";
			this.rbOnlyEvenMoneyAllowed.UseVisualStyleBackColor = true;
			// 
			// groupBox5
			// 
			this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox5.Controls.Add(this.radioButton4);
			this.groupBox5.Controls.Add(this.radioButton2);
			this.groupBox5.Controls.Add(this.radioButton1);
			this.groupBox5.Location = new System.Drawing.Point(12, 241);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(76, 94);
			this.groupBox5.TabIndex = 103;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Shoe has";
			// 
			// radioButton4
			// 
			this.radioButton4.AutoSize = true;
			this.radioButton4.Location = new System.Drawing.Point(6, 53);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(63, 17);
			this.radioButton4.TabIndex = 16;
			this.radioButton4.TabStop = true;
			this.radioButton4.Text = "4 decks";
			this.radioButton4.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(6, 36);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(63, 17);
			this.radioButton2.TabIndex = 15;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "2 decks";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(6, 19);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(58, 17);
			this.radioButton1.TabIndex = 14;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "1 deck";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// groupBox6
			// 
			this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox6.Controls.Add(this.cbCanSplitOn10sAllowed);
			this.groupBox6.Controls.Add(this.rbMax2HandsFromAnySplit);
			this.groupBox6.Controls.Add(this.rbMax4HandsFromAnySplit);
			this.groupBox6.Controls.Add(this.rbMax4HandsFromSplitButOnly2FromAces);
			this.groupBox6.Location = new System.Drawing.Point(93, 241);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(229, 94);
			this.groupBox6.TabIndex = 104;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Splitting Hands";
			// 
			// cbCanSplitOn10sAllowed
			// 
			this.cbCanSplitOn10sAllowed.AutoSize = true;
			this.cbCanSplitOn10sAllowed.Location = new System.Drawing.Point(4, 70);
			this.cbCanSplitOn10sAllowed.Name = "cbCanSplitOn10sAllowed";
			this.cbCanSplitOn10sAllowed.Size = new System.Drawing.Size(120, 17);
			this.cbCanSplitOn10sAllowed.TabIndex = 21;
			this.cbCanSplitOn10sAllowed.Text = "Split on 10s allowed";
			this.cbCanSplitOn10sAllowed.UseVisualStyleBackColor = true;
			// 
			// rbMax2HandsFromAnySplit
			// 
			this.rbMax2HandsFromAnySplit.AutoSize = true;
			this.rbMax2HandsFromAnySplit.Location = new System.Drawing.Point(4, 36);
			this.rbMax2HandsFromAnySplit.Name = "rbMax2HandsFromAnySplit";
			this.rbMax2HandsFromAnySplit.Size = new System.Drawing.Size(150, 17);
			this.rbMax2HandsFromAnySplit.TabIndex = 19;
			this.rbMax2HandsFromAnySplit.TabStop = true;
			this.rbMax2HandsFromAnySplit.Text = "Max 2 hands from any split";
			this.rbMax2HandsFromAnySplit.UseVisualStyleBackColor = true;
			// 
			// rbMax4HandsFromAnySplit
			// 
			this.rbMax4HandsFromAnySplit.AutoSize = true;
			this.rbMax4HandsFromAnySplit.Location = new System.Drawing.Point(4, 19);
			this.rbMax4HandsFromAnySplit.Name = "rbMax4HandsFromAnySplit";
			this.rbMax4HandsFromAnySplit.Size = new System.Drawing.Size(150, 17);
			this.rbMax4HandsFromAnySplit.TabIndex = 18;
			this.rbMax4HandsFromAnySplit.TabStop = true;
			this.rbMax4HandsFromAnySplit.Text = "Max 4 hands from any split";
			this.rbMax4HandsFromAnySplit.UseVisualStyleBackColor = true;
			// 
			// rbMax4HandsFromSplitButOnly2FromAces
			// 
			this.rbMax4HandsFromSplitButOnly2FromAces.AutoSize = true;
			this.rbMax4HandsFromSplitButOnly2FromAces.Location = new System.Drawing.Point(4, 53);
			this.rbMax4HandsFromSplitButOnly2FromAces.Name = "rbMax4HandsFromSplitButOnly2FromAces";
			this.rbMax4HandsFromSplitButOnly2FromAces.Size = new System.Drawing.Size(223, 17);
			this.rbMax4HandsFromSplitButOnly2FromAces.TabIndex = 20;
			this.rbMax4HandsFromSplitButOnly2FromAces.TabStop = true;
			this.rbMax4HandsFromSplitButOnly2FromAces.Text = "Max 2 hands from split aces, 4 from others";
			this.rbMax4HandsFromSplitButOnly2FromAces.UseVisualStyleBackColor = true;
			// 
			// groupBox7
			// 
			this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox7.Controls.Add(this.rbBet5To50);
			this.groupBox7.Controls.Add(this.rbBet10to100);
			this.groupBox7.Controls.Add(this.rbBet2To20);
			this.groupBox7.Location = new System.Drawing.Point(12, 9);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(311, 42);
			this.groupBox7.TabIndex = 105;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Betting";
			// 
			// rbBet5To50
			// 
			this.rbBet5To50.AutoSize = true;
			this.rbBet5To50.Location = new System.Drawing.Point(106, 19);
			this.rbBet5To50.Name = "rbBet5To50";
			this.rbBet5To50.Size = new System.Drawing.Size(70, 17);
			this.rbBet5To50.TabIndex = 2;
			this.rbBet5To50.TabStop = true;
			this.rbBet5To50.Text = "$5 to $50";
			this.rbBet5To50.UseVisualStyleBackColor = true;
			// 
			// rbBet10to100
			// 
			this.rbBet10to100.AutoSize = true;
			this.rbBet10to100.Location = new System.Drawing.Point(209, 19);
			this.rbBet10to100.Name = "rbBet10to100";
			this.rbBet10to100.Size = new System.Drawing.Size(82, 17);
			this.rbBet10to100.TabIndex = 3;
			this.rbBet10to100.TabStop = true;
			this.rbBet10to100.Text = "$10 to $100";
			this.rbBet10to100.UseVisualStyleBackColor = true;
			// 
			// rbBet2To20
			// 
			this.rbBet2To20.AutoSize = true;
			this.rbBet2To20.Location = new System.Drawing.Point(6, 19);
			this.rbBet2To20.Name = "rbBet2To20";
			this.rbBet2To20.Size = new System.Drawing.Size(70, 17);
			this.rbBet2To20.TabIndex = 1;
			this.rbBet2To20.TabStop = true;
			this.rbBet2To20.Text = "$2 to $20";
			this.rbBet2To20.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.button3.CausesValidation = false;
			this.button3.Location = new System.Drawing.Point(93, 432);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(74, 28);
			this.button3.TabIndex = 26;
			this.button3.Text = "Reset";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.button4.CausesValidation = false;
			this.button4.Location = new System.Drawing.Point(171, 398);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(74, 28);
			this.button4.TabIndex = 23;
			this.button4.Text = "Caribbean";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.button5.CausesValidation = false;
			this.button5.Location = new System.Drawing.Point(93, 398);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(74, 28);
			this.button5.TabIndex = 22;
			this.button5.Text = "European";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.button6.CausesValidation = false;
			this.button6.Location = new System.Drawing.Point(249, 397);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(74, 28);
			this.button6.TabIndex = 25;
			this.button6.Text = "Las Vegas";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// groupBox8
			// 
			this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox8.Controls.Add(this.rbDealerGets1Card);
			this.groupBox8.Controls.Add(this.rbDealerGets2cards);
			this.groupBox8.Location = new System.Drawing.Point(93, 336);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(230, 55);
			this.groupBox8.TabIndex = 106;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "Initial Deal Style";
			// 
			// rbDealerGets1Card
			// 
			this.rbDealerGets1Card.AutoSize = true;
			this.rbDealerGets1Card.Location = new System.Drawing.Point(6, 32);
			this.rbDealerGets1Card.Name = "rbDealerGets1Card";
			this.rbDealerGets1Card.Size = new System.Drawing.Size(152, 17);
			this.rbDealerGets1Card.TabIndex = 7;
			this.rbDealerGets1Card.TabStop = true;
			this.rbDealerGets1Card.Text = "Dealer gets only 1 card, up";
			this.rbDealerGets1Card.UseVisualStyleBackColor = true;
			// 
			// rbDealerGets2cards
			// 
			this.rbDealerGets2cards.AutoSize = true;
			this.rbDealerGets2cards.Location = new System.Drawing.Point(6, 15);
			this.rbDealerGets2cards.Name = "rbDealerGets2cards";
			this.rbDealerGets2cards.Size = new System.Drawing.Size(185, 17);
			this.rbDealerGets2cards.TabIndex = 6;
			this.rbDealerGets2cards.TabStop = true;
			this.rbDealerGets2cards.Text = "Dealer gets 2 cards, 1 down, 1 up";
			this.rbDealerGets2cards.UseVisualStyleBackColor = true;
			// 
			// BlackjackConfigurationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CausesValidation = false;
			this.ClientSize = new System.Drawing.Size(335, 472);
			this.Controls.Add(this.groupBox8);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.groupBox7);
			this.Controls.Add(this.groupBox6);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "BlackjackConfigurationForm";
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Blackjack Configuration";
			this.Load += new System.EventHandler(this.BlackjackConfigurationForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.groupBox7.ResumeLayout(false);
			this.groupBox7.PerformLayout();
			this.groupBox8.ResumeLayout(false);
			this.groupBox8.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbDealerDrawsOnSoft17;
		private System.Windows.Forms.RadioButton rbDealerStandsOn17;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton rbBlackjackPaysEvenMoney;
		private System.Windows.Forms.RadioButton rbBlackJackPays3to2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton rbTiedHandsAreAPush;
		private System.Windows.Forms.RadioButton rbDealerPaidOnTies;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.CheckBox cbSurrenderAllowed;
		private System.Windows.Forms.RadioButton rbInsuranceNotAllowed;
		private System.Windows.Forms.RadioButton rbInsuranceAllowed;
		private System.Windows.Forms.RadioButton rbOnlyEvenMoneyAllowed;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.CheckBox cbCanSplitOn10sAllowed;
		private System.Windows.Forms.RadioButton rbMax2HandsFromAnySplit;
		private System.Windows.Forms.RadioButton rbMax4HandsFromAnySplit;
		private System.Windows.Forms.RadioButton rbMax4HandsFromSplitButOnly2FromAces;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.RadioButton rbBet10to100;
		private System.Windows.Forms.RadioButton rbBet2To20;
		private System.Windows.Forms.RadioButton rbBet5To50;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.RadioButton rbDealerGets1Card;
		private System.Windows.Forms.RadioButton rbDealerGets2cards;
	}
}