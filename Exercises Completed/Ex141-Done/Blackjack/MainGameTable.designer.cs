namespace Blackjack
{
	partial class MainGameTable
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGameTable));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.blackjackMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.stackTheDeckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dealTestingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.tableColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.resetDefaultsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripSeparator();
			this.blackjackConfigurationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.otherGamePreferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
			this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.colorFadeTimer = new System.Windows.Forms.Timer(this.components);
			this.PlayingCardImageList = new System.Windows.Forms.ImageList(this.components);
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.stopGameButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.gameToolStripMenuItem,
            this.toolStripMenuItem4,
            this.toolStripMenuItem2,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new System.Drawing.Size(89, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
			// 
			// gameToolStripMenuItem
			// 
			this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blackjackMenuItem});
			this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
			this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.gameToolStripMenuItem.Text = "&Game";
			// 
			// blackjackMenuItem
			// 
			this.blackjackMenuItem.Name = "blackjackMenuItem";
			this.blackjackMenuItem.Size = new System.Drawing.Size(132, 22);
			this.blackjackMenuItem.Text = "&New Game";
			this.blackjackMenuItem.Click += new System.EventHandler(this.blackjackMenuItem_Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stackTheDeckToolStripMenuItem,
            this.dealTestingToolStripMenuItem});
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(76, 20);
			this.toolStripMenuItem4.Text = "&Simulation";
			// 
			// stackTheDeckToolStripMenuItem
			// 
			this.stackTheDeckToolStripMenuItem.Name = "stackTheDeckToolStripMenuItem";
			this.stackTheDeckToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.stackTheDeckToolStripMenuItem.Text = "&Stack the deck...";
			this.stackTheDeckToolStripMenuItem.Click += new System.EventHandler(this.stackTheDeckToolStripMenuItem_Click);
			// 
			// dealTestingToolStripMenuItem
			// 
			this.dealTestingToolStripMenuItem.Name = "dealTestingToolStripMenuItem";
			this.dealTestingToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.dealTestingToolStripMenuItem.Text = "&Test Card Dealing";
			this.dealTestingToolStripMenuItem.Click += new System.EventHandler(this.dealTestingToolStripMenuItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tableColorToolStripMenuItem,
            this.toolStripMenuItem11,
            this.blackjackConfigurationToolStripMenuItem1,
            this.otherGamePreferencesToolStripMenuItem});
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(80, 20);
			this.toolStripMenuItem2.Text = "&Preferences";
			// 
			// tableColorToolStripMenuItem
			// 
			this.tableColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeToolStripMenuItem1,
            this.resetDefaultsToolStripMenuItem1});
			this.tableColorToolStripMenuItem.Name = "tableColorToolStripMenuItem";
			this.tableColorToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
			this.tableColorToolStripMenuItem.Text = "&Table Color";
			// 
			// changeToolStripMenuItem1
			// 
			this.changeToolStripMenuItem1.Name = "changeToolStripMenuItem1";
			this.changeToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
			this.changeToolStripMenuItem1.Text = "&Change...";
			this.changeToolStripMenuItem1.Click += new System.EventHandler(this.changeBackColorMenuItem_Click);
			// 
			// resetDefaultsToolStripMenuItem1
			// 
			this.resetDefaultsToolStripMenuItem1.Name = "resetDefaultsToolStripMenuItem1";
			this.resetDefaultsToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
			this.resetDefaultsToolStripMenuItem1.Text = "&Reset Defaults";
			this.resetDefaultsToolStripMenuItem1.Click += new System.EventHandler(this.resetDefaultBackColorMenuItem_Click);
			// 
			// toolStripMenuItem11
			// 
			this.toolStripMenuItem11.Name = "toolStripMenuItem11";
			this.toolStripMenuItem11.Size = new System.Drawing.Size(221, 6);
			// 
			// blackjackConfigurationToolStripMenuItem1
			// 
			this.blackjackConfigurationToolStripMenuItem1.Name = "blackjackConfigurationToolStripMenuItem1";
			this.blackjackConfigurationToolStripMenuItem1.Size = new System.Drawing.Size(224, 22);
			this.blackjackConfigurationToolStripMenuItem1.Text = "&Configure Game...";
			this.blackjackConfigurationToolStripMenuItem1.Click += new System.EventHandler(this.blackjackConfigMenuItem_Click);
			// 
			// otherGamePreferencesToolStripMenuItem
			// 
			this.otherGamePreferencesToolStripMenuItem.Name = "otherGamePreferencesToolStripMenuItem";
			this.otherGamePreferencesToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
			this.otherGamePreferencesToolStripMenuItem.Text = "&Select Shuffler Algorithm......";
			this.otherGamePreferencesToolStripMenuItem.Click += new System.EventHandler(this.otherGamePreferencesToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.aboutToolStripMenuItem.Text = "&About...";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBar,
            this.StatusLabel});
			this.statusStrip1.Location = new System.Drawing.Point(0, 579);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// ProgressBar
			// 
			this.ProgressBar.Name = "ProgressBar";
			this.ProgressBar.Size = new System.Drawing.Size(100, 16);
			this.ProgressBar.Visible = false;
			// 
			// StatusLabel
			// 
			this.StatusLabel.Font = new System.Drawing.Font("Tahoma", 12F);
			this.StatusLabel.Name = "StatusLabel";
			this.StatusLabel.Size = new System.Drawing.Size(0, 17);
			// 
			// colorFadeTimer
			// 
			this.colorFadeTimer.Interval = 24;
			this.colorFadeTimer.Tick += new System.EventHandler(this.colorFadeTimer_Tick);
			// 
			// PlayingCardImageList
			// 
			this.PlayingCardImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("PlayingCardImageList.ImageStream")));
			this.PlayingCardImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.PlayingCardImageList.Images.SetKeyName(0, "xx.gif");
			this.PlayingCardImageList.Images.SetKeyName(1, "ac.gif");
			this.PlayingCardImageList.Images.SetKeyName(2, "2c.gif");
			this.PlayingCardImageList.Images.SetKeyName(3, "3c.gif");
			this.PlayingCardImageList.Images.SetKeyName(4, "4c.gif");
			this.PlayingCardImageList.Images.SetKeyName(5, "5c.gif");
			this.PlayingCardImageList.Images.SetKeyName(6, "6c.gif");
			this.PlayingCardImageList.Images.SetKeyName(7, "7c.gif");
			this.PlayingCardImageList.Images.SetKeyName(8, "8c.gif");
			this.PlayingCardImageList.Images.SetKeyName(9, "9c.gif");
			this.PlayingCardImageList.Images.SetKeyName(10, "tc.gif");
			this.PlayingCardImageList.Images.SetKeyName(11, "jc.gif");
			this.PlayingCardImageList.Images.SetKeyName(12, "qc.gif");
			this.PlayingCardImageList.Images.SetKeyName(13, "kc.gif");
			this.PlayingCardImageList.Images.SetKeyName(14, "ad.gif");
			this.PlayingCardImageList.Images.SetKeyName(15, "2d.gif");
			this.PlayingCardImageList.Images.SetKeyName(16, "3d.gif");
			this.PlayingCardImageList.Images.SetKeyName(17, "4d.gif");
			this.PlayingCardImageList.Images.SetKeyName(18, "5d.gif");
			this.PlayingCardImageList.Images.SetKeyName(19, "6d.gif");
			this.PlayingCardImageList.Images.SetKeyName(20, "7d.gif");
			this.PlayingCardImageList.Images.SetKeyName(21, "8d.gif");
			this.PlayingCardImageList.Images.SetKeyName(22, "9d.gif");
			this.PlayingCardImageList.Images.SetKeyName(23, "td.gif");
			this.PlayingCardImageList.Images.SetKeyName(24, "jd.gif");
			this.PlayingCardImageList.Images.SetKeyName(25, "qd.gif");
			this.PlayingCardImageList.Images.SetKeyName(26, "kd.gif");
			this.PlayingCardImageList.Images.SetKeyName(27, "ah.gif");
			this.PlayingCardImageList.Images.SetKeyName(28, "2h.gif");
			this.PlayingCardImageList.Images.SetKeyName(29, "3h.gif");
			this.PlayingCardImageList.Images.SetKeyName(30, "4h.gif");
			this.PlayingCardImageList.Images.SetKeyName(31, "5h.gif");
			this.PlayingCardImageList.Images.SetKeyName(32, "6h.gif");
			this.PlayingCardImageList.Images.SetKeyName(33, "7h.gif");
			this.PlayingCardImageList.Images.SetKeyName(34, "8h.gif");
			this.PlayingCardImageList.Images.SetKeyName(35, "9h.gif");
			this.PlayingCardImageList.Images.SetKeyName(36, "th.gif");
			this.PlayingCardImageList.Images.SetKeyName(37, "jh.gif");
			this.PlayingCardImageList.Images.SetKeyName(38, "qh.gif");
			this.PlayingCardImageList.Images.SetKeyName(39, "kh.gif");
			this.PlayingCardImageList.Images.SetKeyName(40, "as.gif");
			this.PlayingCardImageList.Images.SetKeyName(41, "2s.gif");
			this.PlayingCardImageList.Images.SetKeyName(42, "3s.gif");
			this.PlayingCardImageList.Images.SetKeyName(43, "4s.gif");
			this.PlayingCardImageList.Images.SetKeyName(44, "5s.gif");
			this.PlayingCardImageList.Images.SetKeyName(45, "6s.gif");
			this.PlayingCardImageList.Images.SetKeyName(46, "7s.gif");
			this.PlayingCardImageList.Images.SetKeyName(47, "8s.gif");
			this.PlayingCardImageList.Images.SetKeyName(48, "9s.gif");
			this.PlayingCardImageList.Images.SetKeyName(49, "ts.gif");
			this.PlayingCardImageList.Images.SetKeyName(50, "js.gif");
			this.PlayingCardImageList.Images.SetKeyName(51, "qs.gif");
			this.PlayingCardImageList.Images.SetKeyName(52, "ks.gif");
			this.PlayingCardImageList.Images.SetKeyName(53, "00.gif");
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stopGameButton,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripButton1,
            this.toolStripSeparator3,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator4,
            this.toolStripButton5});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1008, 25);
			this.toolStrip1.TabIndex = 4;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// stopGameButton
			// 
			this.stopGameButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.stopGameButton.Image = ((System.Drawing.Image)(resources.GetObject("stopGameButton.Image")));
			this.stopGameButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.stopGameButton.Name = "stopGameButton";
			this.stopGameButton.Size = new System.Drawing.Size(23, 22);
			this.stopGameButton.Text = "toolStripButton1";
			this.stopGameButton.ToolTipText = "Stop Current Game";
			this.stopGameButton.Click += new System.EventHandler(this.stopGameButton_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton2.Text = "toolStripButton2";
			this.toolStripButton2.ToolTipText = "Start new game";
			this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton1.Text = "toolStripButton1";
			this.toolStripButton1.ToolTipText = "Stack The Deck";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
			this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton3.Text = "toolStripButton3";
			this.toolStripButton3.ToolTipText = "Table Color";
			this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
			// 
			// toolStripButton4
			// 
			this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
			this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton4.Name = "toolStripButton4";
			this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton4.Text = "toolStripButton4";
			this.toolStripButton4.ToolTipText = "Configure Game";
			this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButton5
			// 
			this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
			this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton5.Name = "toolStripButton5";
			this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton5.Text = "toolStripButton5";
			this.toolStripButton5.ToolTipText = "About Blackjack";
			this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
			// 
			// MainGameTable
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 601);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainGameTable";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Blackjack";
			this.Load += new System.EventHandler(this.MainGameTable_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripProgressBar ProgressBar;
		internal System.Windows.Forms.ToolStripStatusLabel StatusLabel;
		private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.Timer colorFadeTimer;
		internal System.Windows.Forms.ImageList PlayingCardImageList;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripMenuItem blackjackMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem blackjackConfigurationToolStripMenuItem1;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem11;
		private System.Windows.Forms.ToolStripButton stopGameButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem tableColorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem resetDefaultsToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem stackTheDeckToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton toolStripButton3;
		private System.Windows.Forms.ToolStripButton toolStripButton4;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton toolStripButton5;
		private System.Windows.Forms.ToolStripMenuItem otherGamePreferencesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dealTestingToolStripMenuItem;
	}
}