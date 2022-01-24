namespace Blackjack
{
	partial class OtherPreferencesDialog
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
			this.label1 = new System.Windows.Forms.Label();
			this.btnSelect = new System.Windows.Forms.Button();
			this.ddlSelectItem = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(230, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Sorry, no other preference options are available";
			// 
			// btnSelect
			// 
			this.btnSelect.Location = new System.Drawing.Point(102, 113);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(79, 36);
			this.btnSelect.TabIndex = 2;
			this.btnSelect.Text = "Select";
			this.btnSelect.UseVisualStyleBackColor = true;
			this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
			// 
			// ddlSelectItem
			// 
			this.ddlSelectItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ddlSelectItem.FormattingEnabled = true;
			this.ddlSelectItem.ItemHeight = 20;
			this.ddlSelectItem.Location = new System.Drawing.Point(12, 39);
			this.ddlSelectItem.Name = "ddlSelectItem";
			this.ddlSelectItem.Size = new System.Drawing.Size(260, 64);
			this.ddlSelectItem.TabIndex = 3;
			// 
			// OtherPreferencesDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 162);
			this.ControlBox = false;
			this.Controls.Add(this.ddlSelectItem);
			this.Controls.Add(this.btnSelect);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "OtherPreferencesDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Change Other Preferences";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSelect;
		private System.Windows.Forms.ListBox ddlSelectItem;
	}
}