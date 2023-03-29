using System;
using System.Collections.Generic;
using static System.Random;
using System.Text;

public class Hangman
{
    // Attributes
    private string _letterGuessed;
    private Player player;
    private GallowsRenderer gallowsRenderer;
    private WordGenerator randomWord;
    private PrintLines printLines;

    // Constructors
    public Hangman()
    {
        player = new Player();
        gallowsRenderer = new GallowsRenderer();
        randomWord = new WordGenerator();
        printLines = new PrintLines();
    }
    // Methods

    public void StartGame(string fileName)
    {
        Console.Clear();  // This will clear the console
        SelectRandomWord(fileName);
        // DisplayRandomWord();
        player.ShowRandomWord();
        do
        {
            Console.Clear();  // This will clear the console
            // DisplayRandomWord();
            ShowGallows();
            ShowLettersGuessesRight();
            ShowLettersGuessedWrong();
            ShowNumberOfGuesses();
            PromptPlayerForLetter();
            CheckPlayerGuess();
        } while (!player.GameOver());

        GameOver();
        PlayAgain();


    }
    private void SelectRandomWord(string fileName)
    {
        player.randomWord = randomWord.GetRandomWord(fileName);
    }
    private void DisplayRandomWord()
    {
        Console.WriteLine("\n{0}", player.randomWord);
    }

    private void PromptPlayerForLetter()
    {
        do
        {
            Console.Write("Guess a letter >>  ");
            string g = Console.ReadLine();
            _letterGuessed = g.Substring(0, 1);
        } while (player.CheckIfGuessed(player, _letterGuessed));

        player.lettersGuessed.Add(_letterGuessed);
    }
    private void CheckPlayerGuess()
    {
        player.CheckLatestGuess(_letterGuessed);
        player.ShowRandomWord();
    }

    private void PlayAgain()
    {
        Console.WriteLine($"\nWould you like to play again?, press enter to continue.");

        var input = Console.ReadKey();
        if (input.Key == ConsoleKey.Enter)
        {
            // StartGame();
        }
    }

    private void ShowNumberOfGuesses()
    {
        Console.Write($"\nGuesses Left = {player.wrongGuessCount}/6\n");
    }

    private void ShowGallows()
    {
        gallowsRenderer.ShowGallows(player.wrongGuessCount);
    }

    private void ShowLettersGuessesRight()
    {
        Console.WriteLine($"\n{player.showRandomWord}\n");
    }

    private void ShowLettersGuessedWrong()
    {
        Console.WriteLine($"\n{player.wrongGuesses}\n");
    }

    private void GameOver()
    {
        Console.Clear();  // This will clear the console
        if (player.GameOver() && player.PlayerWon())
        {
            Console.WriteLine("*** Congratulations You Won! ***");
        }
        else
        {
            Console.WriteLine("*** Sorry, you lost! ***");
        }
        ShowGallows();
        Console.Write($"\nThe word was - {player.randomWord}\n");

    }


}