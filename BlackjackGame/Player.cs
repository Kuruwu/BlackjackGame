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
        public static event EventHandler<EventArgs> CardHasAddedToHand; //Card Added to Hand Event
        string playerName;
        int playerMoney;
        int playerBet;
        int sideBet;
        List<Card> currentHand = new List<Card>();

        public int PlayerMoney { get; set; }
        public int PlayerBet { get; set; }
        public Player(string playerName, int playerMoney)
        {
            this.playerName = playerName;
            this.playerMoney = playerMoney;
        }
        public List<Card> CurrentHand { get { return currentHand; } }

        public void Bet(int amount)
        {
            playerBet = amount;
            playerMoney = playerMoney - amount;
        }
        public void AddCardToHand(Card card)
        {
            currentHand.Add(card);
            CardHasAddedToHand?.Invoke(this, EventArgs.Empty);
        }
        public void TakesInsurance()
        {
            sideBet = (playerBet / 2);
            playerMoney -= sideBet; //Need to check if they can afford it
        }
        public void WonInsurance()
        {
            sideBet *= 3;
            playerMoney += sideBet;
        }
        public void LostInsurance()
        {
            sideBet = 0;
        }
        public bool FiveCardTrick()
        {
            if (currentHand.Count == 5 && CalculateHandValue() <= 21)
            {
                return true;
            }
            return false;
        }
        public void PlayerWinsHand()
        {
            playerMoney += playerBet * 2;
        }
        public void PlayerBetsDouble()
        {
            sideBet = playerBet * 2; //Validate if they can afford it again.
        }
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
