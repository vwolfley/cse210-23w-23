using System;

public class ListingActivity : Activity
{
    // Attributes 
    private List<string> _promptList = new List<string>
    {
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
    };
    private List<string> _userList = new List<string>();
    private string[] _prompts = {
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
    };
    private string _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";



    // Constructors
     // Methods
    public ListingActivity(string activityName, int activityTime) : base(activityName, activityTime)
    {
        
    }
    public void GetActivityDescription()
    {
         Console.WriteLine(_description);
    }
     public void GetRandomPrompt(int seconds)
    {
        Console.WriteLine();  //insert blank line to start
        var random = new Random();
        int index = random.Next(_promptList.Count);

        Console.WriteLine($"\n{_promptList[index]}");
    }


   


}