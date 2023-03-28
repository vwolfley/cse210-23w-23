using System;
using System.Collections.Generic;
using static System.Random;
using System.Text;

public class Player
{
    // Attributes
    public string randomWord { get; set; }
    public string guessedLetter { get; set; }
    public List<char> currentLettersGuessed { get; set; }
    public List<char> wrongGuessList { get; set; }
    public string guesses { get; set; }
    public string wrongGuesses { get; set; }
    public int wrongGuessCount;
    public int correctGuessCount;
    // Constructors
    public Player()
    {
        randomWord = string.Empty;
        guessedLetter = string.Empty;
        currentLettersGuessed = new List<char>();
        wrongGuessList = new List<char>();
        guesses = string.Empty;
        wrongGuesses = string.Empty;
        wrongGuessCount = 0;
        correctGuessCount = 0;
    }
    // Methods

    public bool PlayerWon()
    {
        return (correctGuessCount == randomWord.Length);
    }
    public bool PlayerLost()
    {
        return (wrongGuessCount == 7);
    }
    public bool GameOver()
    {
        return ((wrongGuessCount == 6) || (correctGuessCount == randomWord.Length));
    }
    public void CheckLatestGuess(char newGuess)
    {

        bool correctLetter = false;
        string word = randomWord;
        currentLettersGuessed.Add(newGuess);
        // Check if that letter has already been guessed
        if (wrongGuessList.Contains(newGuess))
        {
            Console.Write("\r\n You have already guessed this letter");
        }
        // Check if letter is in randomWord
        else
        {
            for (int i = 0; i < randomWord.Length; i++)
            {
                if (randomWord[i].ToString().Equals(newGuess))
                {
                    correctGuessCount++;
                    correctLetter = true;
                }
            }
            // User was wrong
            if (!correctLetter)
            {
                wrongGuessCount++;
                wrongGuessList.Add(newGuess);
            }
            StringBuilder sb = new StringBuilder();
            sb.Append("Wrong Guessess: [ ");
            foreach (char l in wrongGuessList)
            {
                sb.Append(l).Append(" ");
            }
            sb.Append("]");
            wrongGuesses = sb.ToString();
        }
    }

    public bool CheckIfGuessed(Player player, char newGuess)
    {
        if (player.currentLettersGuessed.Contains(newGuess))
        {
            return true;
        }
        return false;
    }

}