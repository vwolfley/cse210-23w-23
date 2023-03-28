using System;

public class MainMenu
{
    // Attributes
    private string _welcome =@"
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
}
