using System;

public class EternalGoal : Goal
{
    // Attributes
    private string _type;
     private string _name;
    private string _description;
    private int _points;
    private bool _status;


    // Constructors
    public EternalGoal(string type, string name, string description, int points, bool status) : base(type, name, description, points, status)
    {
        _type = type;
        _name = name;
        _description = description;
        _points = points;
        _status = false;
    }

    // Methods

    public override void ListGoal(int i)
    {
        Console.WriteLine($"{i}.  [ ] {_name} ({_description})");
    }
    public override string SaveGoal()
    {
        return ($"{_type}; {_name}; {_description}; {_points}; {_status}");
    }

    public override string LoadGoal()
    {
        return ($"Simple Goal:; {_name}; {_description}; {_points}; {_status}");
    }


}