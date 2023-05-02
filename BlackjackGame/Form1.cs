using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BlackjackGame
{
    public partial class Form1 : Form
    {
        Player playerOne = new Player("", 500);
        Player dealer = new Player("Dealer", 0);
        Deck deck = new Deck();
        System.Windows.Forms.Timer dealerTimer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer tableTimer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer openingHandTimer = new System.Windows.Forms.Timer();
        int playerBet = 0;
        int playerCurrentMoney = Money.CashValueRetrieve;

        public Form1()
        {
            InitializeComponent(); ;
            playerOne.CardHasAddedToHand += CardHasBeenModified; //Subscribing to events.
            dealer.CardHasAddedToHand += CardHasBeenModified; //Event could be static to Player class but causes memory leaks apparently. 
            HitButton.Visible = true;
            dealerTimer.Interval = 1000; //2 seconds.
            dealerTimer.Tick += new EventHandler(DealerCardTimer); //Every interval (Tick) this event is fired.
            tableTimer.Interval = 2000; //3 seconds
            tableTimer.Tick += new EventHandler(ClearTableTimer);
            lblWinCondition.Visible = false;
            openingHandTimer.Interval = 500; //0.5 seconds
            openingHandTimer.Tick += new EventHandler(OpeningHand);
            playerCurrentMoney = Money.CashValueRetrieve;
            playerMoneyLabel.Text = playerCurrentMoney.ToString();
        }
        /// <summary>
        /// Event handler for dealer drawing cards with intervals between them.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DealerCardTimer(object? sender, EventArgs e) //The method that is called to handle the tick event.
        {
            if (dealer.CalculateHandValue() < 17) //Dealer must hit up to 17 and stand.
            {
                dealer.AddCardToHand(deck.DrawCard());
                if (dealer.CalculateHandValue() > 21)
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
            btnBet.Enabled = true;
            UpdateCardImages();
            tableTimer.Stop();
        }

        private void CardHasBeenModified(object? sender, EventArgs e)
        {
            UpdateCardImages();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisablePlayButtons();
            deck.ShuffleDeck();
        }

        private void HitButton_Click(object sender, EventArgs e)
        {
            HideInsuranceButton();
            playerOne.AddCardToHand(deck.DrawCard());
            int playerOneHandTotal = playerOne.CalculateHandValue();
            lblPlayerTotal.Text = playerOneHandTotal.ToString();
            if (playerOne.FiveCardTrick()) //If player has 5 cards not greater than 21 win by default. 
            {
                playerOne.PlayerWinsHand();
                lblWinCondition.Text = "You Win Five Card Trick";
                lblWinCondition.Visible = true;
                ResetTable();
            }
            else if (playerOneHandTotal == 21) //If player has 21 then auto stand.
            {
                HitButton.Enabled = false;
                StandButton_Click(sender, e);
            }
            else if (playerOneHandTotal > 21) //Player Busts and loses.
            {
                lblPlayerTotal.Text = playerOneHandTotal + " " + "BUST";
                HitButton.Enabled = false;
                dealer.CurrentHand[1].flipCard(); //If you bust it flips dealers hidden card and shows lose.
                UpdateCardImages();
                lblWinCondition.Text = "You Lose";
                lblWinCondition.Visible = true;
                ResetTable();
            }
        }

        private void StandButton_Click(object sender, EventArgs e)
        {
            HideInsuranceButton();
            dealerTimer.Start();
            if (dealer.CurrentHand.Count! > 1) //Inside Array bounds Check
            {
                dealer.CurrentHand[1].flipCard(); //Flips Unknown Card. 
                UpdateCardImages();
                lblDealerTotal.Text = dealer.CalculateHandValue().ToString();
            }
            HitButton.Enabled = false;
            StandButton.Enabled = false;
        }

        private void DoubleButton_Click(object sender, EventArgs e)
        {
            HideInsuranceButton();
            playerOne.PlayerBetsDouble();
            playerOne.AddCardToHand(deck.DrawCard());
            HitButton.Enabled = false;
            lblPlayerTotal.Text = playerOne.CalculateHandValue().ToString(); //Need to do a bust check here, Refactor code from hit.
            StandButton_Click((object)sender, e);
        }

        private void SplitButton_Click(object sender, EventArgs e)
        {

        }

        private void increaseBet_Click(object sender, EventArgs e)
        {
            if (playerBet == playerOne.PlayerMoney) //Not Working
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
            btnBet.Enabled = false;
            playerOne.Bet(playerBet); //Temp Bet
            HitButton.Enabled = true;
            StandButton.Enabled = true;
            openingHandTimer.Start();
        }
        /// <summary>
        /// Resets the table after a game.
        /// </summary>
        private void ResetTable()
        {
            //Check player money here if 0 then game over and ask to replace with 500?
            tableTimer.Start();
            playerOne.CurrentHand.Clear();
            dealer.CurrentHand.Clear();
            btnBet.Enabled = false;
            HideInsuranceButton();
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
                //Insert draw method here
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

            if (playerOne.CurrentHand.Count < 2)
            {
                playerOne.AddCardToHand(deck.DrawCard());
                lblPlayerTotal.Text = playerOne.CalculateHandValue().ToString();
            }
            else if (dealer.CurrentHand.Count < 2)
            {
                if (dealer.CurrentHand.Count == 1)
                {
                    dealer.AddCardToHand(deck.DrawCard());
                    dealer.CurrentHand[1].flipCard(); //Need to do flipcard better because it's drawing it for a microsecond before i manually force an update
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
            InsuranceCheck();
            //SplitCheckHere

            //Validate Double And Split buttons here. 
            if (playerOne.PlayerMoney < playerOne.PlayerBet * 2)
            {
                DoubleButton.Enabled = true;
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
                btnInsurance.Visible = true;
                btnInsurance.Enabled = true;
            }
        }

        private void btnInsurance_Click(object sender, EventArgs e)
        {
            btnInsurance.Enabled = false;
            playerOne.TakesInsurance();
            if (dealer.CurrentHand[1].Value == 10)
            {
                dealer.CurrentHand[1].flipCard();
                UpdateCardImages();
                playerOne.WonInsurance();
                ResetTable();
            }
            else
            {
                //Text that dealer did not have blackjack
                playerOne.LostInsurance();
            }
        }
        /// <summary>
        /// Hides and disables Insurance Button
        /// </summary>
        private void HideInsuranceButton()
        {
            btnInsurance.Enabled = false;
            btnInsurance.Visible = false;
        }
        /// <summary>
        /// Disables Hit,Stand,Double,Split buttons, Changes their colour to green. 
        /// </summary>
        private void DisablePlayButtons() //Do this last
        {
            HitButton.Enabled = false;
            HitButton.BackColor = Color.LimeGreen;
            StandButton.Enabled = false;
            StandButton.BackColor = Color.LimeGreen;
            DoubleButton.Enabled = false;
            DoubleButton.BackColor = Color.LimeGreen;
            SplitButton.Enabled = false;
            SplitButton.BackColor = Color.LimeGreen;
        }
    }
}