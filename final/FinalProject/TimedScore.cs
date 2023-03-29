using System;

public class TimedScore : ScoringRules
{
    // Attributes
    private string _type = "Timed Score:";
    private bool _status;

    // Constructors
    public TimedScore(string type, int points) : base(type, points)
    {
        _status = false;
    }
    public TimedScore(string type, int points, bool status) : base(type, points)
    {
        _status = status;
    }
    public Boolean Finished()
    {
        return _status;
    }

    // Methods
    

}