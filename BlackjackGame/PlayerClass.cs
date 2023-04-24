using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackGame
{
    public class PlayerClass : Money
    {
        Money playerMoney = new Money();
        public void playerSetup()
        {
            playerMoney.setMoney();
            List<Card> cards = new List<Card>();
        }
    }
}
