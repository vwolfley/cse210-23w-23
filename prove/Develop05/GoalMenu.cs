using System;

public class GoalMenu
{
    // Attributes 
    private string _menu = $@"
Goal Menu Options
===========================================
The Types of Goals are:
1. Simple Goal
2. Eternal Goal
3. Checklist Goal
4. Back to Main Menu
===========================================
What type of goal would you like to create?  ";

    public string _goalInput;
    private int _goalChoice = 0;

    // Methods
    public int GoalChoice()
    // Method to display choices to user
    {

        Console.Write(_menu);

        _goalInput = Console.ReadLine();
        _goalChoice = 0;
        // This block catches any non integer values that are entered
        try
        {
            _goalChoice = int.Parse(_goalInput);
        }
        catch (FormatException)
        {
            _goalChoice = 0;
        }
        catch (Exception exception)
        {
            Console.WriteLine(
                $"Unexpected error:  {exception.Message}");
        }
        return _goalChoice;
    }



}
