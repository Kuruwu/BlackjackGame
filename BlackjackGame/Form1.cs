namespace BlackjackGame
{
    public partial class Form1 : Form
    {
        int playerBet = 0;
        int playerCurrentMoney = Money.CashValueRetrieve;
        public Form1()
        {
            InitializeComponent();
            PlayerClass player1 = new PlayerClass();
            player1.playerSetup();
            Money playerMoney = new Money();
            playerMoney.setMoney();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            playerCurrentMoney = Money.CashValueRetrieve;
            playerMoneyLabel.Text = playerCurrentMoney.ToString();
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
            else if (playerCurrentMoney >= 10)
            {
                playerBet += 10;
                playerCurrentBet.Text = playerBet.ToString();
                playerCurrentMoney = playerCurrentMoney - 10;
                playerMoneyLabel.Text = playerCurrentMoney.ToString();
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
                playerCurrentMoney = playerCurrentMoney + 10;
                playerMoneyLabel.Text = playerCurrentMoney.ToString();
            }
        }
    }
}