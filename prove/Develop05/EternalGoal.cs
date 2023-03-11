using System;

public class EternalGoal : Goal
{
    // Attributes
     private string _name;
    private string _description;
    private int _points;
    private int _count;


    // Constructors
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    // Methods

    public override void ListGoal()
    {
        Console.WriteLine($"{_count} [ ] {_name} ({_description})");
    }


}