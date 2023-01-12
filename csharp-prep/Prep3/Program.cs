using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");

        // Variables
        string userMagicNumber;
        string userGuess;
        int number;
        int guess;

        /*
        Core Requirement #1
        Ask the user for the magic number.
        Ask the user for a guess.
        Using an if statement, determine if the user needs to:
        guess higher next time
        guess lower next time
        tell them if they guessed it.
        */

        // Ask user for number
        // Console.Write("What is the magic number? ");
        // userMagicNumber = Console.ReadLine();
        // number = int.Parse(userMagicNumber);
        // Ask user for guess
        // Console.Write("What is your guess? ");
        // userGuess = Console.ReadLine();
        // guess = int.Parse(userGuess);

        // if (guess > number)
        // {
        //     Console.WriteLine("Lower");
        // }
        // else if (guess < number)
        // {
        //     Console.WriteLine("Higher");
        // }
        // else
        // {
        //     Console.WriteLine("You guessed it!");
        // }

        /* 
        Core Requirement #2
        Add a loop that keeps looping as long as the guess does not match the magic number.
        */

        // Ask user for number
        // Console.Write("What is the magic number? ");
        // userMagicNumber = Console.ReadLine();
        // number = int.Parse(userMagicNumber);

        // Ask user for guess
        // Console.Write("What is your guess? ");
        // userGuess = Console.ReadLine();
        // guess = int.Parse(userGuess);

        // while (guess != number)
        // {
        //     if (guess > number)
        //     {
        //         Console.WriteLine("Lower");

        //         Console.Write("What is your guess? ");
        //         userGuess = Console.ReadLine();
        //         guess = int.Parse(userGuess);
        //     }
        //     else if (guess < number)
        //     {
        //         Console.WriteLine("Higher");

        //         Console.Write("What is your guess? ");
        //         userGuess = Console.ReadLine();
        //         guess = int.Parse(userGuess);
        //     }
        // }
        // Console.WriteLine("You guessed it!");

        /* 
        Core Requirement #3
        Instead of having the user supply the magic number, generate a random number from 1 to 100
        */
        // Add random number generator 
        Random randomGenerator = new Random();
        number = randomGenerator.Next(1, 100);

        Console.Write("Pick a number between 1 and 100:  ");
        userGuess = Console.ReadLine();
        guess = int.Parse(userGuess);

        while (guess != number)
        {
            if (guess > number)
            {
                Console.WriteLine("Lower");
                Console.Write("What is your guess? ");
                userGuess = Console.ReadLine();
                guess = int.Parse(userGuess);
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
                Console.Write("What is your guess? ");
                userGuess = Console.ReadLine();
                guess = int.Parse(userGuess);
            }
        }
        Console.WriteLine("You guessed it!");







    }
}