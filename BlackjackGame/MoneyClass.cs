using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackGame
{
    public class Money
    {
        private static int cashValue;
        int playersBet;
        //Set the starting money
        public void setMoney()
        {
            cashValue = 1000;
        }

        public void playerBet(int playerCashBet)
        {
            int playerBet = playerCashBet;
            cashValue = cashValue - playersBet;
        }

        public static int CashValueRetrieve
        {
            get { return cashValue; }
            set { cashValue = value; }
        }
        
        
    }
}
