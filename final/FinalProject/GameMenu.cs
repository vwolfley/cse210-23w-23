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
}
