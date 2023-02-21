using System;

public class Activity
{
    // Attributes
    private string _activityName;
    private string _activityDescription;
    private int _duration;
    private string _startingMessage;
    private string _endingMessage;

    // Constructors
    public Activity(string activityName, string activityDescription, int duration)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
        _duration = duration;
    }
    public string GetStartingMessage()
    {
        return _startingMessage;
    }
    public void SetStartingMessage(string startingMessage)
    {
        _startingMessage = startingMessage;
    }
    public string GetEndingMessage()
    {
        return _endingMessage;
    }
    public void SetEndingMessage(string endingMessage)
    {
        _endingMessage = endingMessage;
    }
    public string GetActivityName()
    {
        return _activityName;
    }
    public void SetActivityName(string activityName)
    {
        _activityName = activityName;
    }
    public string GetActivityDescription()
    {
        return _activityDescription;
    }
    public void SetActivityDescription(string activityDescription)
    {
        _activityDescription = activityDescription;
    }
     public int GetDuration()
    {
        return _duration;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }



    // Methods
    public BreathingActivity(string activityName, string activityDescription, int duration) : base(activityName, activityDescription, duration)
    {
        _activityName = "Breathing";
        _activityDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _duration = 50;
    }


}