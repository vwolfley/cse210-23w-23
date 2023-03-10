using System;

public abstract class SimpleGoal : Goal
{
    // Attributes
    private string _goalNameQuestion = "What is the name of your goal?";
    private string _goalDescriptionQuestion = "What is a short description of your goal?";
    private string _goalPointQuestion = "What is the amount of points associated with this goal?";

    // Constructors
    public SimpleGoal(string name, string description, int point) : base(name, description, point)
    {
        Console.WriteLine($"{_goalNameQuestion}  ");
        name = Console.ReadLine();
        Console.WriteLine($"{_goalDescriptionQuestion}  ");
        description = Console.ReadLine();
        Console.WriteLine($"{_goalPointQuestion}  ");
        // point = Console.ReadLine();
        // _userChoice = int.Parse(_userInput);

    }

    // Methods


}