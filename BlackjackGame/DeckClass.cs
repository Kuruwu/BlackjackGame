using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackGame
{
    public class Deck
    {
        List<Card> listOfCards = new List<Card>();

        public List<Card> ListOfCards
        {
            get { return listOfCards; }
        }
        public void createDeck()
        {
            foreach (string suits in Card.validSuits())
            {
                foreach (string ranks in Card.validRanks())
                {
                    Card card = new Card(ranks, suits, false);
                    listOfCards.Add(card);
                }
            }
        }
      
    }
}
