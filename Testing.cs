using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Nikita Grubelias (26604750) OOP Assessment 1

namespace CMP1903M_A01_2223
{
    class Testing
    {
        // Function resposible for inputs and running the functions made
        public Testing()
        {
            // Creates a new ordered pack 
            new Pack();
            Console.WriteLine("Welcome to a Card Shuffling Simulator");
            // While loop that runs as long as the input is not "e" which ends the programme
            while(true)
            {
                Console.WriteLine("Please enter what action you would like to perform ([s]huffle / [d]eal one card / [D]eal multiple cards or [e]nd programme): ");
                // Takes user's input
                string input = Console.ReadLine();
                // Shuffle functions
                if(input == "s")
                {
                    // Determines which shuffle to perform
                    Console.WriteLine("How would you like to shuffle the deck of cards? ([1]Fisher-Yates shuffle / [2]Riffle shuffle or [3]No shuffle) ");
                    while(true)
                    {
                        // Tries to convert the input into an integer, if successful, runs shuffleCardPack, otherwise returns an error message
                        try
                        {
                            int input2 = Convert.ToInt32(Console.ReadLine());
                            Pack.shuffleCardPack(input2);
                            break;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Please enter an integer");
                        }
                    }
                    
                }
                // Deals one card
                if(input == "d")
                {
                    Pack.deal();

                }
                // Deals multiple cards 
                if(input == "D")
                {
                    Console.WriteLine("How many cards you would like to deal? ");
                
                    while(true)
                    {
                        // Tries to convert the input into an integer, if successful runs dealCard, otherwise returns an error message
                        try
                            {
                                int input3 = Convert.ToInt32(Console.ReadLine());
                                Pack.dealCard(input3);
                                break;
                            }
                        catch (Exception)
                            {
                                Console.WriteLine("Please enter an integer");
                            }
                    }
                }
                // If input is "e", ends the loop and returns a goodbye message
                if(input == "e")
                {
                    Console.WriteLine("Thank you for trying my card shuffler, goodbye!");
                    break;
                }
                // If input is not one of the possible inputs, returns an error message
                else
                {
                    if(input != "s" && input != "d" && input != "D" && input != "e")
                        Console.WriteLine("Please enter a valid input (s / d / D / e)");
                }

            }
            
        }
    }
}