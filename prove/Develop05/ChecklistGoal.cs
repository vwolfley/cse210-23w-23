using System;

public class ChecklistGoal : Goal
{
    // Attributes
    private string _type;
    private string _name;
    private string _description;
    private int _points;
    private int _bonusNumber;
    private int _bonusPoints;
    private bool _status;


    // Constructors
    public ChecklistGoal(string type, string name, string description, int points, bool status, int bonusNumber, int bonusPoints) : base(type, name, description, points, status)
    {
        _type = type;
        _name = name;
        _description = description;
        _points = points;
        _bonusNumber = bonusNumber;
        _bonusPoints = bonusPoints;
        _status = false;
    }

    // Methods
    public override void ListGoal(int i)
    {
        Console.WriteLine($"{i}.  [ ] {_name} ({_description})  --  Currently Completed: 0/{_bonusNumber}");
    }
    public override string SaveGoal()
    {
        return ($"{_type}; {_name}; {_description}; {_points}; {_status}; {_bonusNumber}; {_bonusPoints}");
    }
    public override string LoadGoal()
    {
        return ($"Simple Goal:; {_name}; {_description}; {_points}; {_status}");
    }

}