using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BlackjackGame
{
    public partial class Form1 : Form
    {
        Player playerOne = new Player("John", 500);
        Player dealer = new Player("Dealer", 0);
        Deck deck = new Deck();
        System.Windows.Forms.Timer dealerTimer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer tableTimer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer openingHandTimer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer insuranceTimer = new System.Windows.Forms.Timer();
        int rebet = 0;
        int tempMoney;

        public Form1()
        {
            InitializeComponent(); ;
            playerOne.CardHasAddedToHand += CardHasBeenModified; //Subscribing to events.
            dealer.CardHasAddedToHand += CardHasBeenModified;
            HitButton.Visible = true;
            dealerTimer.Interval = 1000; //1 seconds.
            dealerTimer.Tick += new EventHandler(DealerCardTimer); //Every interval (Tick) this event is fired.
            tableTimer.Interval = 2000; //2 seconds
            tableTimer.Tick += new EventHandler(ClearTableTimer);
            lblWinCondition.Visible = false;
            openingHandTimer.Interval = 500; //0.5 seconds
            openingHandTimer.Tick += new EventHandler(OpeningHand);
            insuranceTimer.Interval = 3000; // 3 Seconds
            insuranceTimer.Tick += new EventHandler(InsuranceDisplayTimer);
        }
        /// <summary>
        /// Event handler for dealer drawing cards with a time interval between them.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DealerCardTimer(object? sender, EventArgs e) //Everytime a tick event happens this method is called.
        {
            if (dealer.CurrentHand.Count == 5) //If dealer has 5 cards they must stand. 
            {
                dealerTimer.Stop();
                CheckWinCondition();
            }
            else if (dealer.CalculateHandValue() < 17) //Dealer must hit up to 17 and stand.
            {
                dealer.AddCardToHand(deck.DrawCard());
                if (dealer.CalculateHandValue() > 21) //Dealer has bust
                {
                    lblDealerTotal.Text = dealer.CalculateHandValue().ToString() + " " + "BUST";
                    dealerTimer.Stop();
                    CheckWinCondition();
                }
                else
                {
                    lblDealerTotal.Text = dealer.CalculateHandValue().ToString();
                }
            }
            else if (dealer.CalculateHandValue() < 22) //Dealers hand is 17-21
            {
                lblDealerTotal.Text = dealer.CalculateHandValue().ToString();
                dealerTimer.Stop(); //Stop the timer to prevent further tick events. 
                CheckWinCondition();
            }
        }
        /// <summary>
        /// Event handler for Clearing the table on a timer. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearTableTimer(object? sender, EventArgs e)
        {
            pctDealerCard1.Image = null;
            pctDealerCard2.Image = null;
            pctDealerCard3.Image = null;
            pctDealerCard4.Image = null;
            pctDealerCard5.Image = null;
            pctPlayerCard1.Image = null;
            pctPlayerCard2.Image = null;
            pctPlayerCard3.Image = null;
            pctPlayerCard4.Image = null;
            pctPlayerCard5.Image = null;
            lblWinCondition.Visible = false;
            lblPlayerTotal.Text = "0";
            lblDealerTotal.Text = "0";
            playerOne.PlayerBet = 0; //Reset the bet here because it's easier.
            increaseBet.Enabled = true;
            reduceBet.Enabled = true;
            UpdateMoneyDisplay();
            UpdateCardImages();
            tableTimer.Stop();
            if (playerOne.PlayerMoney == 0)
            {
                MessageBox.Show("Bankrupt! Money has been reset.");
                playerOne.PlayerMoney = 500;
                UpdateMoneyDisplay();
            }
        }
        /// <summary>
        /// Tick event that makes the insurance label disappear after a few seconds. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InsuranceDisplayTimer(object? sender, EventArgs e)
        {
            lblInsurance.Visible = false;
            insuranceTimer.Stop();

        }
        /// <summary>
        /// The event to automatically update cards on drawing a new card. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CardHasBeenModified(object? sender, EventArgs e)
        {
            UpdateCardImages();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisablePlayButtons();
            deck.ShuffleDeck();
            //deck.ShuffleDeckTestDeck();
            playerMoneyLabel.Text = playerOne.PlayerMoney.ToString();
        }

        private void HitButton_Click(object sender, EventArgs e)
        {
            DisableInsuranceButton();
            DisableDoubleButton();
            playerOne.AddCardToHand(deck.DrawCard());
            int playerOneHandTotal = playerOne.CalculateHandValue();
            lblPlayerTotal.Text = playerOneHandTotal.ToString();
            if (playerOne.FiveCardTrick()) //If player has 5 cards not greater than 21 win by default. 
            {
                playerOne.PlayerWinsHand();
                lblWinCondition.Text = "You Win";
                lblWinCondition.Visible = true;
                DisableHitButton();
                DisableStandButton();
                ResetTable();
            }
            else if (playerOneHandTotal == 21) //If player has 21 then auto stand.
            {
                DisableHitButton();
                StandButton_Click(sender, e);
            }
            else if (playerOneHandTotal > 21) //Player Busts and loses.
            {
                lblPlayerTotal.Text = playerOneHandTotal + " " + "BUST";
                DisableHitButton();
                dealer.CurrentHand[1].flipCard(); //If you bust it flips dealers hidden card and shows lose.
                UpdateCardImages();
                lblDealerTotal.Text = dealer.CalculateHandValue().ToString();
                lblWinCondition.Text = "You Lose";
                lblWinCondition.Visible = true;
                ResetTable();
            }
        }

        private void StandButton_Click(object sender, EventArgs e)
        {
            DisableInsuranceButton();
            DisableDoubleButton();
            DisableHitButton();
            DisableStandButton();
            dealerTimer.Start();
            if (dealer.CurrentHand.Count! > 1) //Inside Array bounds Check
            {
                dealer.CurrentHand[1].flipCard(); //Flips Unknown Card. 
                UpdateCardImages();
                lblDealerTotal.Text = dealer.CalculateHandValue().ToString();
            }
        }

        private void DoubleButton_Click(object sender, EventArgs e)
        {
            DisableInsuranceButton();
            playerOne.PlayerBetsDouble();
            playerOne.AddCardToHand(deck.DrawCard());

            UpdateMoneyDisplay();
            DisableHitButton();
            int playerOneHandTotal = playerOne.CalculateHandValue();
            if (playerOneHandTotal > 21) //Player Busts and loses.
            {
                lblPlayerTotal.Text = playerOneHandTotal + " " + "BUST";
                DisableHitButton();
                dealer.CurrentHand[1].flipCard(); //If you bust it flips dealers hidden card and shows lose.
                UpdateCardImages();
                lblDealerTotal.Text = dealer.CalculateHandValue().ToString();
                lblWinCondition.Text = "You Lose";
                lblWinCondition.Visible = true;
                ResetTable();
            }
            else
            {
                lblPlayerTotal.Text = playerOneHandTotal.ToString(); //Need to do a bust check here, Refactor code from hit.
                StandButton_Click((object)sender, e);
            }
        }

        private void SplitButton_Click(object sender, EventArgs e)
        {

        }

        private void increaseBet_Click(object sender, EventArgs e)
        {
            if (playerOne.PlayerMoney == 0)
            {
                return;
            }
            else if (playerOne.PlayerMoney >= 10)
            {
                playerOne.PlayerBet += 10;
                playerCurrentBet.Text = playerOne.PlayerBet.ToString();
                playerOne.PlayerMoney = playerOne.PlayerMoney - 10;
                playerMoneyLabel.Text = playerOne.PlayerMoney.ToString();
                if (playerOne.PlayerBet > 0)
                {
                    EnableBetButton(); //Enabling bet button if bet. 
                }
            }
            else if (playerOne.PlayerMoney < 10) //If the player has less than 10 money just bet whatever they have. 
            {
                tempMoney = playerOne.PlayerMoney;
                playerOne.PlayerBet += playerOne.PlayerMoney;
                playerOne.PlayerMoney = 0;
                UpdateMoneyDisplay();
                EnableBetButton();
            }
        }

        private void reduceBet_Click(object sender, EventArgs e)
        {
            if (tempMoney > 0) //If the player has betted less than 10 money replace with what we stored in increase bet function. 
            {
                playerOne.PlayerBet -= tempMoney;
                playerOne.PlayerMoney += tempMoney;
                UpdateMoneyDisplay();
                tempMoney = 0;

            }
            else if (playerOne.PlayerBet == 0)
            {
                return;
            }
            else
            {
                playerOne.PlayerBet -= 10;
                playerCurrentBet.Text = playerOne.PlayerBet.ToString();
                playerOne.PlayerMoney = playerOne.PlayerMoney + 10;
                playerMoneyLabel.Text = playerOne.PlayerMoney.ToString();
                if (playerOne.PlayerBet == 0)
                {
                    DisableBetButton(); //Disabling bet button if no bet
                }
            }
        }
        /// <summary>
        /// Updates the card images from the resource file based on naming format for dealer and player.
        /// This is automatic when cards are drawn from the deck but needs to be manually invoked elsewhere.
        /// </summary>
        private void UpdateCardImages()
        {
            for (int i = 0; i < playerOne.CurrentHand.Count; i++)
            {
                string pictureBoxName = "pctPlayerCard" + (i + 1); //Picture Box Controls must follow format pctPlayerCard1 etc
                PictureBox pictureBox = (PictureBox)panelPlayerCards.Controls.Find(pictureBoxName, true).FirstOrDefault();
                if (pictureBox != null)
                {
                    pictureBox.Image = playerOne.CurrentHand[i].Image;
                }
            }

            for (int i = 0; i < dealer.CurrentHand.Count; i++)
            {
                string pictureBoxName = "pctDealerCard" + (i + 1); //Picture Box Controls must follow format pctDealerCard1 etc
                PictureBox pictureBox = (PictureBox)panelDealersCards.Controls.Find(pictureBoxName, true).FirstOrDefault();
                if (pictureBox != null)
                {
                    pictureBox.Image = dealer.CurrentHand[i].Image;
                }
            }
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            DisableBetButton();
            DisableBetAmountControls();
            openingHandTimer.Start();
        }
        /// <summary>
        /// Resets the table after a game.
        /// </summary>
        private void ResetTable()
        {
            tableTimer.Start();
            playerOne.CurrentHand.Clear();
            dealer.CurrentHand.Clear();
            btnBet.Enabled = false;
            tempMoney = 0;
            DisableInsuranceButton();
            DisablePlayButtons();
            deck.ResetDeck();
            deck.ShuffleDeck();
        }
        /// <summary>
        /// Checks all the basic win conditions. 
        /// </summary>
        private void CheckWinCondition()
        {
            int playersHand = playerOne.CalculateHandValue(), dealersHand = dealer.CalculateHandValue();

            if (dealersHand > 21 && playersHand < 22) //if dealer has bust
            {
                lblWinCondition.Text = "You Win";
                lblWinCondition.Visible = true;
                playerOne.PlayerWinsHand();
                ResetTable();
            }
            else if (playersHand == dealersHand) //Draw
            {
                lblWinCondition.Text = "Draw";
                lblWinCondition.Visible = true;
                playerOne.PlayerDrawsHand();
                ResetTable();
            }
            else if (playersHand > dealersHand) //Player has higher hand than dealer
            {
                lblWinCondition.Text = "You Win";
                lblWinCondition.Visible = true;
                playerOne.PlayerWinsHand();
                ResetTable();
            }
            else //Lose
            {
                lblWinCondition.Text = "You Lose";
                lblWinCondition.Visible = true;
                //Lose Method
                ResetTable();
            }
        }
        /// <summary>
        /// Deals cards based on a timer event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpeningHand(object sender, EventArgs e)
        {
            //Dealing opening hands in alternate order.
            if (playerOne.CurrentHand.Count < 2)
            {
                if (playerOne.CurrentHand.Count == 1 && dealer.CurrentHand.Count == 0)
                {
                    dealer.AddCardToHand(deck.DrawCard());
                    lblDealerTotal.Text = dealer.CalculateHandValue().ToString();
                }
                else
                {
                    playerOne.AddCardToHand(deck.DrawCard());
                    lblPlayerTotal.Text = playerOne.CalculateHandValue().ToString();
                }
            }
            else if (dealer.CurrentHand.Count < 2)
            {
                if (dealer.CurrentHand.Count == 1)
                {
                    dealer.AddCardToHand(deck.DrawCard());
                    dealer.CurrentHand[1].flipCard(); //Flip dealers hidden card. 
                    UpdateCardImages();
                    lblDealerTotal.Text = dealer.CalculateHandValue().ToString();
                }
                else
                {
                    dealer.AddCardToHand(deck.DrawCard());
                    lblDealerTotal.Text = dealer.CalculateHandValue().ToString();
                }
            }
            else
            {
                openingHandTimer.Stop();
                EnableHitButton();
                EnableStandButton();
                OpeningHandCheck();

            }
        }
        /// <summary>
        /// Checks the Players Opening Hand For BlackJack and Double Eligibility.
        /// </summary>
        private void OpeningHandCheck()
        {
            if (playerOne.CalculateHandValue() == 21)
            {
                playerOne.PlayerWinsHand(); //Playerwin blackjack instead?
                lblWinCondition.Text = "BLACKJACK";
                lblWinCondition.Visible = true;
                ResetTable();
                return;
            }
            //Checking if player can afford insurance. 
            if (playerOne.PlayerMoney >= playerOne.PlayerBet / 2)
            {
                InsuranceCheck();
            }
            //If player can afford doubling their bet.
            if (playerOne.PlayerMoney >= playerOne.PlayerBet)
            {
                EnableDoubleButton();
            }
        }
        private bool BetCheck()
        {
            return false;
        }
        /// <summary>
        /// Enables the Insurance Button during the Opening Check if Dealer holds an ace.
        /// </summary>
        private void InsuranceCheck()
        {
            if (dealer.CurrentHand[0].Value == 11)
            {
                btnInsurance.Enabled = true;
                btnInsurance.BackColor = Color.Orange;
            }
        }

        private void btnInsurance_Click(object sender, EventArgs e)
        {
            btnInsurance.Enabled = false;
            playerOne.TakesInsurance();
            UpdateMoneyDisplay();
            if (dealer.CurrentHand[1].Value == 10)
            {
                dealer.CurrentHand[1].flipCard();
                UpdateCardImages();
                playerOne.WonInsurance();
                lblWinCondition.Text = "Insurance Win";
                lblWinCondition.Visible = true;
                ResetTable();
            }
            else
            {
                lblInsurance.Visible = true;
                insuranceTimer.Start();
                playerOne.LostInsurance();
                DisableInsuranceButton();
                UpdateMoneyDisplay();
            }
        }
        /// <summary>
        /// Disables the Insurance Button
        /// </summary>
        private void DisableInsuranceButton()
        {
            btnInsurance.Enabled = false;
            btnInsurance.BackColor = Color.LimeGreen;
        }
        /// <summary>
        /// Disables Hit,Stand,Double,Split buttons, Changes their colour to green. 
        /// </summary>
        private void DisablePlayButtons()
        {
            DisableHitButton();
            DisableStandButton();
            DisableDoubleButton();
            SplitButton.Enabled = false;
            SplitButton.BackColor = Color.LimeGreen;
        }
        private void EnableBetButton()
        {
            btnBet.Enabled = true;
            btnBet.BackColor = Color.DeepSkyBlue;
        }
        private void DisableBetButton()
        {
            btnBet.Enabled = false;
            btnBet.BackColor = Color.LimeGreen;
        }
        private void EnableHitButton()
        {
            HitButton.Enabled = true;
            HitButton.BackColor = Color.DeepSkyBlue;
        }
        private void DisableHitButton()
        {
            HitButton.Enabled = false;
            HitButton.BackColor = Color.LimeGreen;
        }
        private void EnableStandButton()
        {
            StandButton.Enabled = true;
            StandButton.BackColor = Color.DeepSkyBlue;

        }
        private void DisableStandButton()
        {
            StandButton.Enabled = false;
            StandButton.BackColor = Color.LimeGreen;
        }
        private void EnableDoubleButton()
        {
            DoubleButton.Enabled = true;
            DoubleButton.BackColor = Color.DeepSkyBlue;
        }
        private void DisableDoubleButton()
        {
            DoubleButton.Enabled = false;
            DoubleButton.BackColor = Color.LimeGreen;
        }
        private void UpdateMoneyDisplay()
        {
            playerMoneyLabel.Text = playerOne.PlayerMoney.ToString();
            playerCurrentBet.Text = playerOne.PlayerBet.ToString();
        }
        private void DisableBetAmountControls()
        {
            increaseBet.Enabled = false;
            reduceBet.Enabled = false;
        }

    }
}