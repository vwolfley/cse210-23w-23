using System;

public class MainMenu
{
    // Attributes
    private string _welcome = @"
*******************************************
***                                     ***
***          Welcome to Hangman         ***
***                                     ***
*******************************************";
    private string _menu = $@"
             Main Menu Options
===========================================
Please select one of the following options:
1. Play Game - Untimed
2. Play Game - Timed
3. How to Play
4. Quit
===========================================
Select an option from the menu:  ";

    public string _userInput;
    private int _userChoice = 0;
    private int _action = 0;

    // Methods
    public int UserChoice()
    // Method to display choices to user
    {
        Console.Write(_menu);

        _userInput = Console.ReadLine();
        _userChoice = 0;
        // This block catches any non integer values that are entered
        try
        {
            _userChoice = int.Parse(_userInput);
        }
        catch (FormatException)
        {
            _userChoice = 0;
        }
        catch (Exception exception)
        {
            Console.WriteLine(
                $"Unexpected error:  {exception.Message}");
        }
        return _userChoice;
    }

    public void PrintWelcome()
    {
        Console.Clear();  // This will clear the console
        Console.Write($"{_welcome}\n\n");
    }

    public void MainMenuChoice()
    {
        // Call GameMenu
        GameMenu gameChoice = new GameMenu();
        
        while (_action != 4)
        // switch case for main menu
        {
            // Ask for user input (1-6)
            _action = UserChoice();
            switch (_action)
            {
                case 1:
                    // Play Game - Untimed
                    Console.Clear();  // This will clear the console
                    gameChoice.GameMenuChoice();
                    break;
                case 2:
                    // Play Game - Timed
                    gameChoice.GameMenuChoice();
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
