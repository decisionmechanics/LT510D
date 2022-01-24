using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace CharacterSetTest
{
	/// <summary>
	/// Summary description for CharTestWin.
	/// </summary>
	public class CharTestWin : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListBox listBox1;
		private ListBox listBox2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public CharTestWin()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			CharTest ct = new CharTest();
			//string line = ct.ComposeHeader();
			//listBox1.Items.Add(line);
			for (int i = 0; i <= 0xFFFF; i+=CharTest.CPL )
			{
				string line = ct.ComposeLine(i);
				listBox1.Items.Add(line);
			}
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(8, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(624, 290);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.ItemHeight = 22;
            this.listBox2.Location = new System.Drawing.Point(8, 4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(624, 26);
            this.listBox2.TabIndex = 1;
            // 
            // CharTestWin
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(640, 341);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CharTestWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CharTestWin";
            this.Load += new System.EventHandler(this.CharTestWin_Load);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new CharTestWin());
		}

		private void CharTestWin_Load(object sender, EventArgs e)
		{
			listBox2.Items.Add("      0  1  2  3  4  5  6  7  8  9  A  B  C  D  E  F");
		}
	}
}
