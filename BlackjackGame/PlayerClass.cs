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
            playerMoney.playerBet();
            Deck deck = new Deck();
            deck.ShuffleDeck();
            Card playerCardOne = deck.DrawCard();
            Card playerCardTwo = deck.DrawCard();
        }
    }
}
