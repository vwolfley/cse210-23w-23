using System;

public class GameMenu
{
    // Attributes 
    private string _menu = $@"
                Game Options
===========================================
Your Game Options are:
1. Random Words
2. Pick your word topic
3. Back to Main Menu
===========================================
Which game would you like to play?  ";

    private string _userInput;
    private int _userChoice = 0;
    private int _action = 0;
    private string _wordFileName;

    // Constructors
    // public GameMenu(string menu, string userInput, int userChoice, int action, string wordFileName) : base(menu, userInput, userChoice, action)
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
        // Call ListMenu
        ListMenu listMenu = new ListMenu();

        while (_action != 3)
        // switch case for goals menu
        {
            _action = UserChoice();
            switch (_action)
            {
                case 1:
                    // Random Words
                    // start game
                    _wordFileName = "words2.txt";
                    Hangman game = new Hangman();
                    game.StartGame(_wordFileName);
                    break;
                case 2:
                    // Pick your word topic
                    Console.Clear();  // This will clear the console
                    listMenu.MenuChoice();
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
    }
}
