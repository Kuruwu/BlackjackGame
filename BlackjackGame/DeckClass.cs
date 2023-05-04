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
        /// <summary>
        /// Creates a Standard 52 Card Deck. 
        /// </summary>
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
        /// Shuffles the current deck using Fisher - Yates Shuffle. 
        /// </summary>
        public void ShuffleDeck()
        {
            Random random = new Random();
            for (int i = 51; i > 0; i--)
            {
                int j = random.Next(0, i + 1);
                Card temp = listOfCards[i];
                listOfCards[i] = listOfCards[j];
                listOfCards[j] = temp;
            }
        } 
        /// <summary>
        /// A class that makes a custom deck for debugging. 
        /// </summary>
        public void ShuffleDeckTestDeck()
        {
            listOfCards[0] = listOfCards[8];
            listOfCards[1] = listOfCards[4];
            listOfCards[2] = listOfCards[10];
            listOfCards[3] = listOfCards[6];
            listOfCards[4] = listOfCards[14];
            listOfCards[5] = listOfCards[13];
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
