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
4. Back to Main Menu
===========================================";

    public string _listInput;
    private int _listChoice = 0;
    private int _action = 0;

    // Methods
    public int ListChoice()
    // Method to display choices to user
    {
        Console.Clear();  // This will clear the console
        Console.Write(_menu);

        _listInput = Console.ReadLine();
        _listChoice = 0;
        // This block catches any non integer values that are entered
        try
        {
            _listChoice = int.Parse(_listInput);
        }
        catch (FormatException)
        {
            _listChoice = 0;
        }
        catch (Exception exception)
        {
            Console.WriteLine(
                $"Unexpected error:  {exception.Message}");
        }
        return _listChoice;
    }

    public void ListMenuChoice()
    {
        while (_action != 4)
        // switch case for list menu
        {
            _action = ListChoice();
            switch (_action)
            {
                case 1:
                    Console.WriteLine("Success Choice 1!");
                    break;
                case 2:
                    Console.WriteLine("Success Choice 2!");
                    break;
                case 3:
                    Console.WriteLine("Success Choice 3!");
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
