using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int magicNumber = random.Next(1, 101); // Generate a random number from 1 to 100
        int guess;
        int attempts = 0;
        bool playAgain = true;

        while (playAgain)
        {
            Console.WriteLine("Guess My Number Game!");
            attempts = 0;
            magicNumber = random.Next(1, 101);

            do
            {
                Console.Write("What is your guess? ");
                if (int.TryParse(Console.ReadLine(), out guess))
                {
                    if (guess < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (guess > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine("You guessed it!");
                    }

                    attempts++;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            } while (guess != magicNumber);

            Console.WriteLine($"It took you {attempts} attempts to guess the magic number.");

            Console.Write("Do you want to play again? (yes/no): ");
            string playAgainInput = Console.ReadLine();
            playAgain = (playAgainInput.ToLower() == "yes");
        }
    }
}