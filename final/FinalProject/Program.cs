using System;
using System.IO;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Call MainMenu
        MainMenu choice = new MainMenu();
        // Call GameMenu
        GameMenu gameChoice = new GameMenu();
        // Call Renderer
        Renderer renderer = new Renderer();

        // Print welcome message
        choice.PrintWelcome();


        int action = 0;
        while (action != 4)
        // switch case for main menu
        {
            // Ask for user input (1-6)
            action = choice.UserChoice();
            switch (action)
            {
                case 1:
                    // Play Game - Untimed
                    Console.Clear();  // This will clear the console
                    // Ask for user input (1-4)
                    int gameInput = 0;
                    while (gameInput != 3)
                    // switch case for goals menu
                    {
                        gameInput = gameChoice.GameChoice();
                        switch (gameInput)
                        {
                            case 1:
                                // Random Words

                                break;
                            case 2:
                                // Pick your word topic

                                break;
                            case 3:
                                // Back to Main Menu
                                Console.Clear();  // This will clear the console
                                break;
                            default:
                                Console.WriteLine($"\nSorry the option you entered is not valid.");
                                break;
                        }
                    }
                    break;
                case 2:
                    // Play Game - Timed
                    Console.Clear();  // This will clear the console
                    // Ask for user input (1-4)
                    gameInput = 0;
                    while (gameInput != 3)
                    // switch case for goals menu
                    {
                        gameInput = gameChoice.GameChoice();
                        switch (gameInput)
                        {
                            case 1:
                                // Random Words

                                break;
                            case 2:
                                // Pick your word topic

                                break;
                            case 3:
                                // Back to Main Menu
                                Console.Clear();  // This will clear the console
                                break;
                            default:
                                Console.WriteLine($"\nSorry the option you entered is not valid.");
                                break;
                        }
                    }

                    break;
                case 3:
                    // How to Play
                    HowToPlay info = new HowToPlay();
                    info.GetInstructions();
                    break;
                case 4:
                    // Quite
                    Console.WriteLine("\nThank you for playing Hangman!\n");
                    break;
                default:
                    Console.WriteLine($"\nSorry the option you entered is not valid.");
                    break;
            }
        }
    }
}
