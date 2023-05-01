using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackGame
{
    public class Deck
    {
        List<Card> listOfCards = new List<Card>();

        public Deck()
        {
            createDeck(); //creates a deck of 52 cards on object instantiation
        }

        public List<Card> ListOfCards
        {
            get { return listOfCards; }
        }
        
        private void createDeck()
        {
            foreach (string suits in Card.validSuits())
            {
                foreach (string ranks in Card.validRanks())
                {
                    Card card = new Card(ranks, suits);
                    listOfCards.Add(card);
                }
            }
        }
        /// <summary>
        /// Shuffles the current deck using Yates Shuffle. 
        /// </summary>
        public void ShuffleDeck()
        {
            Random random = new Random();
            for (int i = listOfCards.Count() - 1; i > 0; i--)
            {
                int j = random.Next(0, 52);
                Card temp = listOfCards[i];
                listOfCards[i] = listOfCards[j];
                listOfCards[j] = temp;
            }
        } 

        /// <summary>
        /// Draws a card from the top of the deck and removes it.
        /// </summary>
        /// <returns>Returns a Card Object</returns>
        public Card DrawCard()
        {
            if (listOfCards != null && listOfCards.Count > 0) //Null checking
            {
                Card playerCard;
                playerCard = listOfCards[0];
                listOfCards.Remove(playerCard);
                return playerCard;
            }
            throw new Exception("The deck of cards is null or empty");
        }

        /// <summary>
        /// Removes existing deck and creates a new ordered 52 card deck.
        /// </summary>
        public void ResetDeck()
        {
            listOfCards.Clear();
            createDeck();
        }
    }
}
