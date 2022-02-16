namespace HiLoGame
{
    partial class MainForm
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
            this.messageLabel = new System.Windows.Forms.Label();
            this.guessTextBox = new System.Windows.Forms.TextBox();
            this.guessButton = new System.Windows.Forms.Button();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attemptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attemptsLabel = new System.Windows.Forms.Label();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            this.messageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.messageLabel.Location = new System.Drawing.Point(12, 42);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(356, 66);
            this.messageLabel.TabIndex = 0;
            this.messageLabel.Text = "messageLabel";
            // 
            // guessTextBox
            // 
            this.guessTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guessTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guessTextBox.Location = new System.Drawing.Point(12, 128);
            this.guessTextBox.Name = "guessTextBox";
            this.guessTextBox.Size = new System.Drawing.Size(117, 29);
            this.guessTextBox.TabIndex = 1;
            // 
            // guessButton
            // 
            this.guessButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guessButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guessButton.Location = new System.Drawing.Point(140, 125);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(86, 34);
            this.guessButton.TabIndex = 2;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(380, 24);
            this.mainMenuStrip.TabIndex = 4;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.generalToolStripMenuItem.Text = "&General";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.newGameToolStripMenuItem.Text = "&New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attemptsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // attemptsToolStripMenuItem
            // 
            this.attemptsToolStripMenuItem.Name = "attemptsToolStripMenuItem";
            this.attemptsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.attemptsToolStripMenuItem.Text = "&Attempts...";
            this.attemptsToolStripMenuItem.Click += new System.EventHandler(this.attemptsToolStripMenuItem_Click);
            // 
            // attemptsLabel
            // 
            this.attemptsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.attemptsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.attemptsLabel.Location = new System.Drawing.Point(231, 131);
            this.attemptsLabel.Name = "attemptsLabel";
            this.attemptsLabel.Size = new System.Drawing.Size(137, 23);
            this.attemptsLabel.TabIndex = 5;
            this.attemptsLabel.Text = "0 attempt(s)";
            // 
            // MainForm
            // 
            this.AcceptButton = this.guessButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 168);
            this.Controls.Add(this.attemptsLabel);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.guessTextBox);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hi-Lo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label messageLabel;
        private TextBox guessTextBox;
        private Button guessButton;
        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem generalToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem attemptsToolStripMenuItem;
        private Label attemptsLabel;
    }
}