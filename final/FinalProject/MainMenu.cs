using System;

public class MainMenu : Menu
{
    // Attributes
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

    private string _welcome = @"
*******************************************
***                                     ***
***          Welcome to Hangman         ***
***                                     ***
*******************************************";
    private string _goodbye = @"
*******************************************
***                                     ***
***    Thank you for playing Hangman!   ***
***                                     ***
*******************************************";

    // Constructors

    // Methods
    public override int UserChoice()
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

    public override void MenuChoice()
    {
        // Call GameMenu
        Menu gameMenu = new GameMenu();
        // Print welcome message
        PrintWelcome();

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
                    gameMenu.MenuChoice();
                    break;
                case 2:
                    // Play Game - Timed
                    Console.Clear();  // This will clear the console
                    gameMenu.MenuChoice();
                    break;
                case 3:
                    // How to Play
                    HowToPlay info = new HowToPlay();
                    info.GetInstructions();
                    break;
                case 4:
                    // Quite
                    PrintGoodbye();
                    break;
                default:
                    Console.WriteLine($"\nSorry the option you entered is not valid.");
                    break;
            }
        }
    }
    private void PrintWelcome()
    {
        Console.Clear();  // This will clear the console
        Console.Write($"{_welcome}\n\n");
    }
    private void PrintGoodbye()
    {
        Console.Clear();  // This will clear the console
        Console.Write($"{_goodbye}\n\n");
    }
}
