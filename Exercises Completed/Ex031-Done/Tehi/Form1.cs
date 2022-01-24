namespace Tehi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DealButtton_Click(object sender, EventArgs e)
        {
            LogListBox.Items.Clear();
            LogListBox.Items.Add("The spade symbol is \u2660");

            StatusLabel.Text = "Deal button pressed";
        }
    }
}