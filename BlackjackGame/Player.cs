using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackGame
{
    public class Player
    {
        public event EventHandler<EventArgs> CardHasAddedToHand; //Card Added to Hand Event
        string playerName;
        int playerMoney;
        int playerBet;
        int sideBet;
        List<Card> currentHand = new List<Card>();

        public int PlayerMoney
        {
            get { return playerMoney; }
            set { playerMoney = value; }
        }
        public int PlayerBet
        {
            get { return playerBet; }
            set { playerBet = value; }
        }

        public Player(string playerName, int playerMoney)
        {
            this.playerName = playerName;
            this.playerMoney = playerMoney;
        }
        public List<Card> CurrentHand { get { return currentHand; } }

        public void AddCardToHand(Card card)
        {
            currentHand.Add(card);
            CardHasAddedToHand?.Invoke(this, EventArgs.Empty);
        }
        public void TakesInsurance()
        {
            sideBet = (playerBet / 2);
            playerMoney -= sideBet; 
        }
        /// <summary>
        /// Insurance pays 2:1
        /// </summary>
        public void WonInsurance()
        {
            sideBet *= 3;
            playerMoney += sideBet;
            sideBet = 0;
        }
        public void LostInsurance()
        {
            sideBet = 0;
        }
        /// <summary>
        /// Check if player has 5 cards with a total value under 21 
        /// </summary>
        /// <returns>True if they have do else false</returns>
        public bool FiveCardTrick()
        {
            if (currentHand.Count == 5 && CalculateHandValue() <= 21)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Standard payout 1:1
        /// </summary>
        public void PlayerWinsHand()
        {
            playerMoney += playerBet * 2;

        }
        public void PlayerLosesHand()
        {
            playerBet = 0;
        }
        /// <summary>
        /// Bet is returned
        /// </summary>
        public void PlayerDrawsHand()
        {
            playerMoney += playerBet;
        }
        /// <summary>
        /// Player doubles their bet.
        /// </summary>
        public void PlayerBetsDouble()
        {
            playerMoney -= playerBet;
            playerBet = playerBet * 2;
        }
        /// <summary>
        /// Calculates the total sum of all cards in hand, if Aces are present and over 21 reduce their value.
        /// </summary>
        /// <returns>Integer sum of hand</returns>
        public int CalculateHandValue()
        {
            int sum = 0;
            bool noMoreAces = false;
            while (!noMoreAces)
            {
                sum = 0;
                foreach (Card card in currentHand)
                {
                    if (card.Faceup == true)
                    {
                        sum = sum + card.Value;
                    }
                }
                if (sum > 21)
                {
                    for (int i = 0; i < currentHand.Count; i++)
                    {
                        if (currentHand[i].Value == 11)
                        {
                            currentHand[i].Value = 1;
                            sum -= 10; //Remove 10 off the sum variable as this is not checked again. 
                            break; //Changing only the First 11 Value Ace found to 1 if hand exceeds 21. 
                        }
                        else 
                        {
                            noMoreAces = true;
                        }
                    }

                }
                else
                {
                    noMoreAces = true;
                }
            }
            return sum;
        }
    }
}
