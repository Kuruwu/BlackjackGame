﻿using System;
using System.Security.Cryptography;

namespace BlackjackGame
{
	public class Card
	{
        string rank;
		string suit;
		bool faceup;
		Image image;
		int value;
		private static Dictionary<string, int> cardValues = new Dictionary<string, int>();
        public string Rank
		{
			get { return rank; }
		}
		public string Suit
		{
			get { return suit; }
		}
		public bool Faceup
		{
			get { return faceup; }
		}
		public Image Image 
		{
			get { return image; }
		}
		public int Value
		{
			get { return value; }
			set { this.value = value; }
		}

		static Card()
		{
            //This dictionary will convert our strings for the card.Rank to their associated value.
            cardValues.Add("2", 2);
            cardValues.Add("3", 3);
            cardValues.Add("4", 4);
            cardValues.Add("5", 5);
            cardValues.Add("6", 6);
            cardValues.Add("7", 7);
            cardValues.Add("8", 8);
            cardValues.Add("9", 9);
            cardValues.Add("10", 10);
            cardValues.Add("Jack", 10);
            cardValues.Add("Queen", 10);
            cardValues.Add("King", 10);
            cardValues.Add("Ace", 11); // Aces can be worth 1 or 11
        }
		/// <summary>
		/// 
		/// </summary>
		/// <param name="cardRank"></param>
		/// <param name="cardSuit"></param>
		/// <param name="cardFaceup"></param>
		public Card(string cardRank, string cardSuit, bool cardFaceup = true)
		{
			rank = cardRank;
			suit = cardSuit;
			faceup = cardFaceup;
			value = cardValues[rank];
            if (faceup == true)
            {
                image = getCardImage();
            }
            else
            {
                image = CardImageResources.red; //Fixme
            };
		}
        /// <summary>
        /// Flip this card objects faceUp value and sets its image. 
        /// </summary>
        public void flipCard()
		{
			this.faceup = !this.faceup;
            if (faceup == true)
            {
                image = getCardImage();
            }
            else
            {
				image = CardImageResources.red; //Fixme
            }
        }
		/// <summary>
		/// A method that returns valid ranks.
		/// </summary>
		/// <returns>An Array of ranks in string format</returns>
		public static string[] validRanks()
		{
			string[] validRanks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "King", "Queen" };
			return validRanks;
		}
		/// <summary>
		/// A method that returns valid suits
		/// </summary>
		/// <returns>An Array of suits in string format</returns>
		public static string[] validSuits()
		{
			string[] validSuits = { "Hearts", "Clubs", "Spades", "Diamonds" };
			return validSuits;
		}
		/// <summary>
		/// Assigns each card an image once it's instantiated based on rank and suit"
		/// </summary>
		/// <returns>Image if exists else null</returns>
		private Image getCardImage()
		{
			string resourceName = (suit.ToLower() + "_" + rank.ToLower());
			// Gets the resource based on filename.
			return (Image)CardImageResources.ResourceManager.GetObject(resourceName); 
        }
	}
}