using System;

public class TimedScore : ScoringRules
{
    // Attributes
    private bool _status;

    // Constructors
    public TimedScore(int points) : base(points)
    {
        _status = false;
    }
    public TimedScore(int points, bool status) : base(points)
    {
        _status = status;
    }
    public Boolean Finished()
    {
        return _status;
    }

    // Methods
    public void ScoreCorrectWord()
    // You can score up to 10 points for each correct word. 
    {

    }
     public void BonusScore()
    // You can score CorrectScoreWord x 2 for each correct word. 
    {

    }
    

}