using System;

public abstract class ScoringRules
{
    // Attributes
    private int _points;


    // Constructors
    public ScoringRules(int points)
    {
        _points = points;
    }
    public int GetPoints()
    {
        return _points;
    }


    // Methods
    

}