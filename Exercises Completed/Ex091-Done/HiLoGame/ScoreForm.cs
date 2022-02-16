namespace HiLoGame
{
    public partial class ScoreForm : Form
    {
        public ScoreForm()
        {
            InitializeComponent();
        }

        public void Update(double averageAttempts)
        {
            scoresListBox.Items.Insert(0, $"At {DateTime.Now.ToShortTimeString()} the average # of attempts was {averageAttempts:N2}");
        }
    }
}
