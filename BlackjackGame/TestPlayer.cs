using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackGame
{
    internal class Class1
    {
        string playerName;
        decimal playerMoney;
        decimal playerBet;
        decimal sideBet;
        List<Card> currentHand = new List<Card>();

        public Class1(string playerName, int playerMoney)
        {
            this.playerName = playerName;
            this.playerMoney = playerMoney;
        }

        public void Bet(decimal amount)
        {
            playerBet = amount;
            playerMoney = playerMoney - amount;
        }
        public void TakesInsurance()
        {
            if (playerBet % 2 != 0)
            {
                //Code for odd number
            } 
            playerBet = (playerBet / 2);
        }
        public void WonInsurance()
        {


        }
        public void Split()
        {

        }
    }
}
