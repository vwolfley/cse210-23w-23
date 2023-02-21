using System;

public class ListeningActivity : Activity
{
    // Attributes 
    private List<string> _promptList = new List<string>();
    private List<string> _userList = new List<string>();
    private string[] _prompts = {
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
    };



    // Constructors
    public ListeningActivity(string activityName, string activityDescription, int duration) : base(activityName, activityDescription, duration)
    {
        _activityName = "Listening";
        _activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _duration = 50;
    }


    // Methods


}