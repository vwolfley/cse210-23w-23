using System;
using System.Collections.Generic;
using static System.Random;
using System.Text;

public class Hangman
{
    // Attributes
    private char _letterGuessed;
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

    public void StartGame()
    {
        Console.Clear();  // This will clear the console
        SelectRandomWord();
        printLines.GetLines(player.randomWord);
        // DisplayRandomWord();
        do
        {
            ShowGallows();
            randomWord.ShowRandomWord(player.currentLettersGuessed, player.randomWord);
            ShowLettersGuessed();
            PromptPlayerForLetter();
            CheckPlayerGuess();
        } while (!player.GameOver());
        DisplayRandomWord();



    }
    private void SelectRandomWord()
    {
        player.randomWord = randomWord.GetRandomWord();
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
            _letterGuessed = Console.ReadLine()[0];
        } while (player.CheckIfGuessed(player, _letterGuessed));

        player.currentLettersGuessed.Add(_letterGuessed);
    }
    private void CheckPlayerGuess()
    {
        player.CheckLatestGuess(_letterGuessed);
        randomWord.ShowRandomWord(player.currentLettersGuessed, player.randomWord);
    }




    private void DisplayResults()
    {

    }

    private void ShowGallows()
    {
        gallowsRenderer.ShowGallows(player.wrongGuessCount);
    }

    private void ShowLettersGuessed()
    {
        Console.WriteLine(player.wrongGuesses);
        Console.WriteLine("");
    }


}