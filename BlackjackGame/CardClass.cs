using System;

namespace BlackjackGame
{
	public class Card
	{
		string rank;
		string suit;
		bool faceup;
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
		/// <summary>
		/// 
		/// </summary>
		/// <param name="cardRank"></param>
		/// <param name="cardSuit"></param>
		/// <param name="cardFaceup"></param>
		public Card(string cardRank, string cardSuit, bool cardFaceup)
		{
			rank = cardRank;
			suit = cardSuit;
			faceup = cardFaceup;
		}
		/// <summary>
		/// A method to flip a boolean
		/// </summary>
		/// <param name="cardflip"></param>
		/// <returns></returns>
		public bool flipCard(bool cardflip)
		{
			return cardflip = !cardflip;
		}
		/// <summary>
		/// A method that returns valid ranks.
		/// </summary>
		/// <returns>An Array of ranks in string format</returns>
		public static string[] validRanks()
		{
			string[] validRanks = { "ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "king", "queen" };
			return validRanks;
		}
		/// <summary>
		/// A method that returns valid suits
		/// </summary>
		/// <returns>An Array of ranks in string format</returns>
		public static string[] validSuits()
		{
			string[] validSuits = { "heart", "club", "spade", "diamond" };
			return validSuits;
		}

	}
}