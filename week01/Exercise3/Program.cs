using System;

class Program
{
    static void Main(string[] args)
    {
        // Stretch Challenge: Outer loop to play the whole game again
        string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
        {
            // --- Core Requirement 3: Generate a Random Number ---
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;
            int guessCount = 0;

            Console.WriteLine("I'm thinking of a number between 1 and 100.");

            // --- Core Requirement 2: Loop until the guess matches ---
            while (guess != magicNumber)
            {
                // Core Requirement 1: Ask for a guess
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++; // Stretch Challenge: Track number of guesses

                // Core Requirement 1: Higher/Lower logic
                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            // --- Stretch Challenge: Final stats and play again prompt ---
            Console.WriteLine($"It took you {guessCount} guesses.");
            
            Console.Write("Do you want to play again (yes/no)? ");
            playAgain = Console.ReadLine();
        }

        Console.WriteLine("Thanks for playing!");
    }
}