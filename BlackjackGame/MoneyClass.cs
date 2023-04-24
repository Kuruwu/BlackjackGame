using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackGame
{
    public class Money
    {
        int cashValue;
        int playersBet;
        //Set the starting money
        public void setMoney()
        {
            cashValue = 1000;
        }

        public void playerBet()
        {
            int playerBet = //TextBox1.Text(); This will be changed when the betting system is implemented
            cashValue = cashValue - playersBet;
        }

        public void winScenario()
        {
            if ((playerCardOne + playerCardTwo) > ((dealerCardOne + dealerCardTwo))
            {
                cashValue += playersBet + playersBet;
                return;
            }
            else if ((playerCardOne + playerCardTwo)) < ((dealerCardOne + dealerCardTwo)) 
            {
                return;
            }
            else if ((playerCardOne + playerCardTwo)) == ((dealerCardOne + dealerCardTwo)) 
            {
                cashValue += playersBet;
                return;
            }
        }
        
    }
}
