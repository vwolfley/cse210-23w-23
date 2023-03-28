using System;

public abstract class ScoringRules
{
    // Attributes
    private string _type;
    private int _points;


    // Constructors
    public ScoringRules(string type, int points)
    {
        _type = type;
        _points = points;
    }
    public string GetType()
    {
        return _type;
    }
    public int GetPoints()
    {
        return _points;
    }


    // Methods
    

}