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

    public string _gameInput;
    private int _gameChoice = 0;
    private int _action = 0;

    private string _wordFileName;

    // Methods
    public int GameChoice()
    // Method to display choices to user
    {
        Console.Clear();  // This will clear the console
        Console.Write(_menu);

        _gameInput = Console.ReadLine();
        _gameChoice = 0;
        // This block catches any non integer values that are entered
        try
        {
            _gameChoice = int.Parse(_gameInput);
        }
        catch (FormatException)
        {
            _gameChoice = 0;
        }
        catch (Exception exception)
        {
            Console.WriteLine(
                $"Unexpected error:  {exception.Message}");
        }
        return _gameChoice;
    }

    public void GameMenuChoice()
    {
        // Call ListMenu
        ListMenu listMenu = new ListMenu();

        while (_action != 3)
        // switch case for goals menu
        {
            _action = GameChoice();
            switch (_action)
            {
                case 1:
                    // Random Words
                    // start game
                    _wordFileName ="words2.txt";
                    Hangman game = new Hangman();
                    game.StartGame(_wordFileName);
                    break;
                case 2:
                    // Pick your word topic
                    Console.Clear();  // This will clear the console
                    listMenu.ListMenuChoice();
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
