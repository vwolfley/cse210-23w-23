using System;

public class SimpleGoal : Goal
{
    // Attributes
    private string _type;
    private string _name;
    private string _description;
    private int _points;
    private bool _status;

    // Constructors
    public SimpleGoal(string type, string name, string description, int points, bool status) : base(type, name, description, points, status)
    {
        _type = type;
        _name = name;
        _description = description;
        _points = points;
        _status = false;
    }

    // Methods
    public void CreateGoal()
    {
        Console.WriteLine($"TEST ");
        _name = Console.ReadLine();
        Console.WriteLine($"TEST2  ");
        _description = Console.ReadLine();
        Console.WriteLine($"LONG TEST  ");
        _points = int.Parse(Console.ReadLine());
    }

    public override void ListGoal(int i)
    {
        if (_status == false)
        {
            Console.WriteLine($"{i}.  [ ] {_name} ({_description})");
        }
        else if (_status == true)
        {
            Console.WriteLine($"{i}.  [X] {_name} ({_description})");
        }
    }
    public override string SaveGoal()
    {
        return ($"{_type}; {_name}; {_description}; {_points}; {_status}");
    }
    public override string LoadGoal()
    {
        return ($"{_type}; {_name}; {_description}; {_points}; {_status}");
    }

}