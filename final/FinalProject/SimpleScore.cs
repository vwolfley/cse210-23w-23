using System;

public class SimpleScore : ScoringRules
{
    // Attributes
    private string _type = "Simple Score:";
    private bool _status;

    // Constructors
    public SimpleScore(string type, int points) : base(type, points)
    {
        _status = false;
    }
    public SimpleScore(string type, int points, bool status) : base(type, points)
    {
        _status = status;
    }
    public Boolean Finished()
    {
        return _status;
    }

    // Methods
    

}