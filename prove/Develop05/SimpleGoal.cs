using System;

public class SimpleGoal : Goal
{
    // Attributes
    private string _name;
    private string _description;
    private int _points;
    private int _bonusPoints;
    private string _status;
    private string _goalNameQuestion = "What is the name of your goal?";
    private string _goalDescriptionQuestion = "What is a short description of your goal?";
    private string _goalPointQuestion = "What is the amount of points associated with this goal?";
    private string _pointChoice;

    private int _count;

    // Constructors
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _name = name;
        _description = description;
        _points = points;

    }

    // Methods
    // public override void CreateGoal()
    // {
    //     Console.WriteLine($"{_goalNameQuestion}  ");
    //     _name = Console.ReadLine();
    //     Console.WriteLine($"{_goalDescriptionQuestion}  ");
    //     _description = Console.ReadLine();
    //     Console.WriteLine($"{_goalPointQuestion}  ");
    //     _pointChoice = Console.ReadLine();
    //     _points = int.Parse(_pointChoice);
    // }

    public override void ListGoal()
    {
        
        Console.WriteLine($"{_count} [ ] {_name} ({_description})");
    }

}