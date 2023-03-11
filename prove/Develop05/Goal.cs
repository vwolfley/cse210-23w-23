using System;

public abstract class Goal
{
    // Attributes
    private string _type;
    private string _name;
    private string _description;
    private int _points;
    private bool _status;


    // Constructors
    public Goal(string type, string name, string description, int points, bool status)
    {
        _type = type;
        _name = name;
        _description = description;
        _points = points;
        _status = false;
    }


    // Methods
    public abstract void ListGoal(int i);
    public abstract string SaveGoal();
    public abstract string LoadGoal();






}