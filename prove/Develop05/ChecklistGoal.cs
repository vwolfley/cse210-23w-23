using System;

public class ChecklistGoal : Goal
{
    // Attributes
    private string _type = "Check List Goal:";
    private int _numberTimes;
    private int _bonusPoints;
    private bool _status;
    private int _counter;


    // Constructors
    public ChecklistGoal(string type, string name, string description, int points, int numberTimes, int bonusPoints) : base(type, name, description, points)
    {
        _status = false;
        _numberTimes = numberTimes;
        _bonusPoints = bonusPoints;
        _counter = 0;
    }
    public ChecklistGoal(string type, string name, string description, int points, bool status, int numberTimes, int bonusPoints, int counter) : base(type, name, description, points)
    {
        _status = status;
        _numberTimes = numberTimes;
        _bonusPoints = bonusPoints;
        _counter = counter;
    }

    public int GetTimes()
    {
        return _counter;
    }
    public void SetTimes()
    {
        _counter = _counter + 1;
    }
    public Boolean Finished()
    {
        return _status;
    }

    // Methods
    public override void ListGoal(int i)
    {
         if (Finished() == false)
        {
            Console.WriteLine($"{i}. [ ] {GetName()} ({GetDescription()})  --  Currently Completed: {_counter}/{_numberTimes}");
        }
        else if (Finished() == true)
        {
            Console.WriteLine($"{i}. [X] {GetName()} ({GetDescription()})  --  Completed: {_counter}/{_numberTimes}");
        }
        
    }
    public override string SaveGoal()
    {
        return ($"{_type}; {GetName()}; {GetDescription()}; {GetPoints()}; {_status}; {_numberTimes}; {_bonusPoints}; {_counter}");
    }
    public override string LoadGoal()
    {
        return ($"Simple Goal:; {GetName()}; {GetDescription()}; {GetPoints()}; {_status}; {_numberTimes}; {_bonusPoints}; {_counter}");
    }
    public override void RecordGoalEvent(List<Goal> goals)
    {
        _status = true;
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
    }

}