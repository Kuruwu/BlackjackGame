namespace BlackjackGame
{
    public partial class Form1 : Form
    {
        int playerBet = 0;
        public Form1()
        {
            InitializeComponent();
            PlayerClass player1 = new PlayerClass();
            player1.playerSetup();
            Money playerMoney = new Money();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void HitButton_Click(object sender, EventArgs e)
        {

        }

        private void StandButton_Click(object sender, EventArgs e)
        {

        }

        private void DoubleButton_Click(object sender, EventArgs e)
        {

        }

        private void SplitButton_Click(object sender, EventArgs e)
        {

        }

        private void increaseBet_Click(object sender, EventArgs e)
        {
            if (playerBet == Money.CashValueRetrieve) 
            {
                return;
            }
            else
            {
                playerBet += 10;
                playerCurrentBet.Text = playerBet.ToString();
            }
        }

        private void reduceBet_Click(object sender, EventArgs e)
        {
            if (playerBet == 0)
            {
                return;
            }
            else
            {
                playerBet -= 10;
                playerCurrentBet.Text = playerBet.ToString();
            }
        }
    }
}