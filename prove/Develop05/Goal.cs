using System;

public abstract class Goal
{
    // Attributes
    private string _name;
    private string _description;
    private int _points;
    private int _bonusPoints;
    private string _status;
    // private List<GoalEntry> goals = new List<GoalEntry>();

    // Constructors
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }



    // Methods
    public abstract void ListGoal();
    // public abstract void RecordEvent();

    // public abstract string MarkComplete();





}