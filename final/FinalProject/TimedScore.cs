using System;
using System.Threading;

public class TimedScore : ScoringRules
{
    // Attributes
    private Timer _timer = null;
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

    private static void StartTimer()
    {
        // Create a Timer object that knows to call our TimerCallback
        // method once every 2000 milliseconds.
        // _timer = new Timer(TimerCallback, null, 0, 2000);
        // Wait for the user to hit <Enter>
        Console.ReadLine();
    }
    private static void TimerCallback(Object o)
    {
        // Display the date/time when this method got called.
        Console.WriteLine("In TimerCallback: " + DateTime.Now);
    }


}