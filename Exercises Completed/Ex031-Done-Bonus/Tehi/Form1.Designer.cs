namespace Tehi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LogListBox = new System.Windows.Forms.ListBox();
            this.DealButtton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.top10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetDefaultColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SwapButton0 = new System.Windows.Forms.Button();
            this.SwapButton1 = new System.Windows.Forms.Button();
            this.SwapButton4 = new System.Windows.Forms.Button();
            this.SwapButton2 = new System.Windows.Forms.Button();
            this.SwapButton3 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.PlayingCardImageList = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogListBox
            // 
            this.LogListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogListBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogListBox.FormattingEnabled = true;
            this.LogListBox.HorizontalScrollbar = true;
            this.LogListBox.ItemHeight = 16;
            this.LogListBox.Location = new System.Drawing.Point(12, 38);
            this.LogListBox.Name = "LogListBox";
            this.LogListBox.Size = new System.Drawing.Size(625, 100);
            this.LogListBox.TabIndex = 0;
            // 
            // DealButtton
            // 
            this.DealButtton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DealButtton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DealButtton.Location = new System.Drawing.Point(277, 310);
            this.DealButtton.Name = "DealButtton";
            this.DealButtton.Size = new System.Drawing.Size(96, 32);
            this.DealButtton.TabIndex = 2;
            this.DealButtton.Text = "Deal";
            this.DealButtton.UseVisualStyleBackColor = true;
            this.DealButtton.Click += new System.EventHandler(this.DealButtton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.preferencesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(649, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.top10ToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "&Game";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // top10ToolStripMenuItem
            // 
            this.top10ToolStripMenuItem.Name = "top10ToolStripMenuItem";
            this.top10ToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.top10ToolStripMenuItem.Text = "Top 10";
            this.top10ToolStripMenuItem.Click += new System.EventHandler(this.top10ToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tableColorToolStripMenuItem,
            this.resetDefaultColorToolStripMenuItem});
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.preferencesToolStripMenuItem.Text = "&Preferences";
            // 
            // tableColorToolStripMenuItem
            // 
            this.tableColorToolStripMenuItem.Name = "tableColorToolStripMenuItem";
            this.tableColorToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.tableColorToolStripMenuItem.Text = "Table Color...";
            this.tableColorToolStripMenuItem.Click += new System.EventHandler(this.tableColorToolStripMenuItem_Click);
            // 
            // resetDefaultColorToolStripMenuItem
            // 
            this.resetDefaultColorToolStripMenuItem.Name = "resetDefaultColorToolStripMenuItem";
            this.resetDefaultColorToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.resetDefaultColorToolStripMenuItem.Text = "Reset Default Color";
            this.resetDefaultColorToolStripMenuItem.Click += new System.EventHandler(this.resetDefaultColorToolStripMenuItem_Click);
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
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 359);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(649, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.SystemColors.Control;
            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameTextBox.Location = new System.Drawing.Point(12, 311);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(96, 29);
            this.NameTextBox.TabIndex = 5;
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginButton.Location = new System.Drawing.Point(144, 310);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(96, 32);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // SwapButton0
            // 
            this.SwapButton0.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SwapButton0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SwapButton0.Location = new System.Drawing.Point(12, 255);
            this.SwapButton0.Name = "SwapButton0";
            this.SwapButton0.Size = new System.Drawing.Size(96, 32);
            this.SwapButton0.TabIndex = 7;
            this.SwapButton0.Text = "Swap";
            this.SwapButton0.UseVisualStyleBackColor = true;
            this.SwapButton0.Click += new System.EventHandler(this.SwapButton0_Click);
            // 
            // SwapButton1
            // 
            this.SwapButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SwapButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SwapButton1.Location = new System.Drawing.Point(144, 255);
            this.SwapButton1.Name = "SwapButton1";
            this.SwapButton1.Size = new System.Drawing.Size(96, 32);
            this.SwapButton1.TabIndex = 8;
            this.SwapButton1.Text = "Swap";
            this.SwapButton1.UseVisualStyleBackColor = true;
            this.SwapButton1.Click += new System.EventHandler(this.SwapButton1_Click);
            // 
            // SwapButton4
            // 
            this.SwapButton4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SwapButton4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SwapButton4.Location = new System.Drawing.Point(541, 255);
            this.SwapButton4.Name = "SwapButton4";
            this.SwapButton4.Size = new System.Drawing.Size(96, 32);
            this.SwapButton4.TabIndex = 9;
            this.SwapButton4.Text = "Swap";
            this.SwapButton4.UseVisualStyleBackColor = true;
            this.SwapButton4.Click += new System.EventHandler(this.SwapButton4_Click);
            // 
            // SwapButton2
            // 
            this.SwapButton2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SwapButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SwapButton2.Location = new System.Drawing.Point(277, 255);
            this.SwapButton2.Name = "SwapButton2";
            this.SwapButton2.Size = new System.Drawing.Size(96, 32);
            this.SwapButton2.TabIndex = 10;
            this.SwapButton2.Text = "Swap";
            this.SwapButton2.UseVisualStyleBackColor = true;
            this.SwapButton2.Click += new System.EventHandler(this.SwapButton2_Click);
            // 
            // SwapButton3
            // 
            this.SwapButton3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SwapButton3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SwapButton3.Location = new System.Drawing.Point(410, 255);
            this.SwapButton3.Name = "SwapButton3";
            this.SwapButton3.Size = new System.Drawing.Size(96, 32);
            this.SwapButton3.TabIndex = 11;
            this.SwapButton3.Text = "Swap";
            this.SwapButton3.UseVisualStyleBackColor = true;
            this.SwapButton3.Click += new System.EventHandler(this.SwapButton3_Click);
            // 
            // PlayingCardImageList
            // 
            this.PlayingCardImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(649, 381);
            this.Controls.Add(this.SwapButton3);
            this.Controls.Add(this.SwapButton2);
            this.Controls.Add(this.SwapButton4);
            this.Controls.Add(this.SwapButton1);
            this.Controls.Add(this.SwapButton0);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.DealButtton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.LogListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Eyes Have It!";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox LogListBox;
        private Button DealButtton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem gameToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem top10ToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem preferencesToolStripMenuItem;
        private ToolStripMenuItem tableColorToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel StatusLabel;
        private TextBox NameTextBox;
        private Button LoginButton;
        private Button SwapButton0;
        private Button SwapButton1;
        private Button SwapButton4;
        private Button SwapButton2;
        private Button SwapButton3;
        private ColorDialog colorDialog1;
        private ToolStripMenuItem resetDefaultColorToolStripMenuItem;
        private ImageList PlayingCardImageList;
    }
}