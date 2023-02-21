using System;

public class BreathingActivity : Activity
{
    // Attributes 
    private string _message1 = "Breathe in...";
    private string _message2 = "Breathe out...";

    // Constructors
    public BreathingActivity(string activityName, string activityDescription, int duration) : base(activityName, activityDescription, duration)
    {
        _activityName = "Breathing";
        _activityDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _duration = 50;
    }


    // Methods
   

}



