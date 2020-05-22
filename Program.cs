using System;
using System.Collections.Generic;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int secretNumber = random.Next(1, 101);

            int guessesGiven = 0;

            int difficultySetting = 0;

            Console.WriteLine("Difficulty Setting? Type Easy, Medium, Hard or EXTREME");

            string userChoice = Console.ReadLine();

            if (userChoice == "Easy")
            {
                difficultySetting = 8;
            }
            else if (userChoice == "Medium")
            {
                difficultySetting = 6;
            }
            else if (userChoice == "Hard")
            {
                difficultySetting = 4;
            }
            else if (userChoice == "EXTREME")
            {
                difficultySetting = int.MaxValue;
            }
            else
            {
                Console.WriteLine("Not an acceptable choice");

            }

            while (guessesGiven < difficultySetting)
            {
                Console.WriteLine($"Guess the secret number. Your guess ({guessesGiven + 1})");

                string userGuess = Console.ReadLine();
                int userGuessInt = Int32.Parse(userGuess);

                if (userGuessInt < secretNumber)
                {
                    Console.WriteLine("Guess was too low!");

                }
                else if (userGuessInt > secretNumber)
                {
                    Console.WriteLine("Guess was too high!");
                }
                else
                {
                    Console.WriteLine("Winner Winner Chicken Dinner!");
                    break;
                }

                guessesGiven++;
            }

            Console.WriteLine("Game Over!");

        }
    }
}