using System;

public class HowToPlay
{
    // Attributes 
    private string _howToPlay = $@"
HOW TO PLAY HANGMAN
===========================================
The Game
Hangman is a classic word game in which you must guess the secret word one letter at a time.

* Guess one letter at a time to reveal the secret word.
* Each incorrect guess adds another part to the hangman. 
* You only get 6 incorrect guesses.

The Points
* You can score up to 10 points for each correct word. 
* Points are subtracted for each incorrect guess. 
* If you get 2 correct answers in a row, you'll get 2x the points (up to 20 points) for the second word. 
* For 3 or more consecutive words, you'll get 3x the points (up to 30 points) for each word. 
* Try to keep your streak going!
===========================================

*** Press Enter to return to menu ***";

    public void GetInstructions()
    {
        Console.Clear();  // This will clear the console

        Console.Write(_howToPlay);
        // Enter key to exit page
        var input = Console.ReadKey();
        if (input.Key == ConsoleKey.Enter)
        {
            Console.Clear();  // This will clear the console
            // Return to main menu
        }
    }

}
