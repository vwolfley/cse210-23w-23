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
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public int GetPoints()
    {
        return _points;
    }
    public void SetPoints(int points)
    {
        _points = points;
    }

    // Methods
    public void ListGoals()
    {
        Console.WriteLine("Your Goals are:");
    }

    public void SaveGoal(string filename)
    {

    }

    public void LoadGoal(string filename)
    {

    }
    public abstract void RecordEvent();
    public abstract void CreateGoal();
    public abstract string MarkComplete();

    



}