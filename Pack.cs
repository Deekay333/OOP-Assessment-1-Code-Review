using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Nikita Grubelias (26604750) OOP Assessment 1

namespace CMP1903M_A01_2223
{
    class Pack
    {
        // Creates private lists to utilize later
        static List<Card> pack = new List<Card>(52);
        static List<Card> pack2 = new List<Card>();
        static List<int> order = new List<int>(52);
        static List<int> reverseOrder = new List<int>(52);
        // Creates a private random number generator useful for the Fisher-Yates shuffle later
        static System.Random rng = new System.Random();
        
        public Pack()
        {
            // A nested for loop for the Card's suits and Values to be in the correct order
            for (int Suit = 1; Suit<=4; Suit++)
            {
                for (int Value = 1; Value <= 13; Value++)
                {
                    // Creates a card, giving 2 inputs for the Card function, one for the value and one for the suit
                    pack.Add(new Card(Value,Suit));
                }
            }
        }
        
        // Defines a card shuffling function
        public static bool shuffleCardPack(int typeOfShuffle)
        {
            // Fisher-Yates shuffle
            if(typeOfShuffle == 1)
            {
                // Creates a list of 52 integers which are easier to work with than lists of objects
                for(int loops = 0; loops < 52; loops++)
                {
                    order.Add(loops);
                }
                // For every item in the order list, takes a random value and puts it to the end of the reverse order function
                for(int loops2 = 51; loops2 >= 0; loops2--)
                {
                    int random = rng.Next(0, loops2);
                    reverseOrder.Add(order[random]);
                    order.Remove(order[random]);
                }
                // Reverses the reverse order of the function to follow the Fisher-Yates shuffle principle
                for(int loops3 = 0; loops3 < 52; loops3++)
                {
                    order.Add(reverseOrder.Last());
                    reverseOrder.Remove(reverseOrder.Last());
                }
                // Makes the pack list follow the order of the recently made and modified order list 
                pack = order.Select(i => pack[i]).ToList();
                // Clears the order list for multiple shuffles to be possible
                order.Clear();
                return true;
            }
            // Riffle shuffle
            if(typeOfShuffle == 2)
            {
                // Creates a nested for loop to take one value from the first half of the deck, then the second half of the deck, alternating
                for (int loops = 0; loops < 26; loops++)
                {
                    for(int type = 0; type <2; type++)
                    {
                        if(type == 0)
                        {
                            order.Add(loops);
                        }
                        else if(type == 1)
                        {
                            order.Add(loops + 26);
                        }
                    }
                }
                // Makes the pack list follow the order of the order list
                pack = order.Select(i => pack[i]).ToList();
                // Clears order for multiple shuffles
                order.Clear();
                return true;
            }
            // No shuffle; this exists only so if typeofshuffle equals 3, it doesn't return an error
            if(typeOfShuffle == 3)
            {
                return true;
            }
            else
            {
                // If the input is not one of the values 1 to 3, return an error message
                Console.WriteLine("Please enter a valid value from 1 to 3");
                return false;
            }
            

        }
        // Deals one card
        public static Card deal()
        {
            // Deals the card
            Console.WriteLine(pack[0].Identify());
            // Adds the card to pack (at the end of it)
            pack.Add(pack[0]);
            // Removes the card at the beginning of the list so it's possible to call this function 52 times and all 52 cards are shown
            pack.Remove(pack[0]);
            return pack[0];
        }
        // Deals the number of cards specified by 'amount'
        public static List<Card> dealCard(int amount)
        {
            if(amount <= 52)
                // Takes every card from the first card to the 'amount' card and prints the Suit and Value of the cards in that range
                foreach(Card card in pack.GetRange(0,amount))
                {
                    Console.WriteLine(card.Identify());
                }
            
            // If the value is not from 1 to 52, returns an error message
            else
            {
                Console.WriteLine("Please enter a valid value from 1 to 52");
            }
            return pack;
        }
    }
}
