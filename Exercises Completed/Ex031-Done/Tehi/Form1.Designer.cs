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
            this.LogListBox = new System.Windows.Forms.ListBox();
            this.DealButtton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.LogListBox.Location = new System.Drawing.Point(12, 12);
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 359);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(649, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.SystemColors.Control;
            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(649, 381);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.DealButtton);
            this.Controls.Add(this.LogListBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Eyes Have It!";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox LogListBox;
        private Button DealButtton;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel StatusLabel;
    }
}