using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Nikita Grubelias (26604750) OOP Assessment 1

namespace CMP1903M_A01_2223
{
    class Card
    {
        //Creates Value and Suit variables
        private int Value;
        private int Suit;

        public Card(int Value, int Suit)
        {
            this.Value = Value;
            this.Suit = Suit;
        }
        //Identify function converts two integers into a CardSuit and a Card Value
        public string Identify()
        {
            string CardSuit = "";
            string CardValue = "";
            
            switch (Value)
            {
                case 1:
                    CardValue = "Ace";
                    break;
                case 11:
                    CardValue = "Jack";
                    break;
                case 12:
                    CardValue = "Queen";
                    break;
                case 13:
                    CardValue = "King";
                    break;
                default:
                    CardValue = Value.ToString();
                    break;
            }
            switch (Suit)
            {
                case 1:
                {
                    CardSuit = " of Clubs";
                    break;
                }
                case 2:
                {
                    CardSuit = " of Diamonds";
                    break;
                }
                case 3:
                {
                    CardSuit = " of Hearts";
                    break;
                }
                case 4:
                {
                    CardSuit = " of Spades";
                    break;
                }
            }
            //Adds the two strings together making it into one large string for the whole card
            CardValue += CardSuit;
            //Outputs the card
            return CardValue;
        }
    }
}
