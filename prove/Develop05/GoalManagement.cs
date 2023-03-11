using System;

public class GoalManagement

{
    // Attributes
    private List<Goal> _listGoals = new List<Goal>();
    private int _totalPoints;


    // Constructors
    public GoalManagement()
    {
        _totalPoints = 0;
    }
    public int GetTotalPoints()
    {
        return _totalPoints;
    }


    // Methods
    public void AddGoal(Goal goal)
    {
        _listGoals.Add(goal);
    }

    public void ListGoals()
    {
        Console.WriteLine("\nYour Goals are:");
        // Loop though goals list
        int index = 1;
        foreach (Goal goal in _listGoals)
        {
            goal.ListGoal(index);
            index = index + 1;
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is your name for this goal file?  ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";

        using (StreamWriter outputFile = new StreamWriter(userFileName))
        {
            foreach (Goal g in _listGoals)
            {
                outputFile.WriteLine(g.SaveGoal());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the name of your goal file?  ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";

        if (File.Exists(userFileName))
        {
            List<string> readText = File.ReadAllLines(userFileName).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();
            foreach (string line in readText)
            {
                string[] entries = line.Split("; ");

                string type = entries[0];
                string name = entries[1];
                string description = entries[2];
                int points = int.Parse(entries[3]);
                bool status = Convert.ToBoolean(entries[4]);

                if (entries[0] == "Simple Goal:")
                {
                    SimpleGoal sGoal = new SimpleGoal(type, name, description, points, status);
                    AddGoal(sGoal);
                }
                if (entries[0] == "Eternal Goal:")
                {
                    EternalGoal eGoal = new EternalGoal(type, name, description, points, status);
                    AddGoal(eGoal);
                }
                if (entries[0] == "Check List Goal:")
                {
                    int bonusNumber = int.Parse(entries[5]);
                    int bonusPoints = int.Parse(entries[6]);
                    ChecklistGoal clGoal = new ChecklistGoal(type, name, description, points, status, bonusNumber, bonusPoints);
                    AddGoal(clGoal);
                }
            }
        }
    }


}