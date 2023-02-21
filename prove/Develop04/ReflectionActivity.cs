using System;

public class ReflectionActivity : Activity
{
    // Attributes 
    private List<string> _promptList = new List<string>();
    private List<string> _questionList = new List<string>();
    private string[] _prompts = {
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."
        };
    private string[] _questions = {
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"
     };

    private string _prompt;

    private string _question;


    // Constructors
    public ReflectionActivity(string activityName, string activityDescription, int duration) : base(activityName, activityDescription, duration)
    {
        _activityName = "Reflecting";
        _activityDescription = "This activity will help you reflect on times ...";
        _duration = 50;
    }



    // Methods


}