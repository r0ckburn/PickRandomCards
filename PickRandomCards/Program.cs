using System;

namespace PickRandomCards
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display a message in the console to enter the number of cards to pick
            Console.Write("Enter the number of cards to pick: ");
            // Read the input entered in the console and return as a string
            string line = Console.ReadLine();
            //
            if (int.TryParse(line, out int numberOfCards))
            {
                // this block is executed if line could be converted to an int
                // value that's stored in a new variable called numberOfCards
                foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine(card);
                }
            }
            else
            {
                // this block is executed if line COULD NOT be converted to an int
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}
