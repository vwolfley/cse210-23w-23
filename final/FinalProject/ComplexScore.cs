using System;

public class ComplexScore : ScoringRules
{
    // Attributes
    private string _type = "Complex Score:";
    private bool _status;

    // Constructors
    public ComplexScore(string type, int points) : base(type,  points)
    {
        _status = false;
    }
    public ComplexScore(string type, int points, bool status) : base(type,  points)
    {
        _status = status;
    }
    public Boolean Finished()
    {
        return _status;
    }

    // Methods


}