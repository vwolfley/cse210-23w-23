using System;

public class ListMenu
{
    // Attributes 
    private string _menu = $@"
                List Options
===========================================
Your list Options are:
1. Colors
2. Sports
3. Seasons
4. Back to Game Menu
===========================================
Which list would you like to use?  ";

    private string _userInput;
    private int _userChoice = 0;
    private int _action = 0;
    private string _wordFileName;

    // Constructors
    // public ListMenu(string menu, string userInput, int userChoice, int action, string wordFileName) : base(menu, userInput, userChoice, action)
    // {
    //     _wordFileName = wordFileName;
    // }

    // Methods
    public int UserChoice()
    // Method to display choices to user
    {
        Console.Clear();  // This will clear the console
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

    public void MenuChoice()
    {
        while (_action != 4)
        // switch case for list menu
        {
            Hangman game = new Hangman();
            _action = UserChoice();
            switch (_action)
            {
                case 1:
                    // Console.WriteLine("Success Choice 1!");
                    _wordFileName = "colors.txt";
                    game.StartGame(_wordFileName);
                    break;
                case 2:
                    _wordFileName = "sports.txt";
                    game.StartGame(_wordFileName);
                    // Console.WriteLine("Success Choice 2!");
                    break;
                case 3:
                    _wordFileName = "seasons.txt";
                    game.StartGame(_wordFileName);
                    // Console.WriteLine("Success Choice 3!");
                    break;
                case 4:
                    // Back to Main Menu
                    Console.Clear();  // This will clear the console
                    break;
                default:
                    Console.WriteLine($"\nSorry the option you entered is not valid.");
                    break;
            }
        }
    }
}
