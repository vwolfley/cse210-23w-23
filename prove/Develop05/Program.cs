using System;
using System.IO;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Use to convert text to title case
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        // List for all goals
        List<Goal> goals = new List<Goal>();


        // This will clear the console
        Console.Clear();
        Console.Write("\n*** Welcome to the Eternal Quest Program ****\n");

        int totalPoints = 0;
        Console.Write($"\nYou currently have {totalPoints} points!\n");
        //Call MainMenu
        MainMenu choice = new MainMenu();
        //Call GoalMenu
        GoalMenu goalChoice = new GoalMenu();


        int action = 0;
        while (action != 6)
        // switch case for main menu
        {
            // Ask for user input (1-6)
            action = choice.UserChoice();
            switch (action)
            {
                case 1:
                    // Create New Goal
                    // This will clear the console
                    Console.Clear();
                    // Ask for user input (1-4)
                    int goalInput = 0;
                    while (goalInput != 4)
                    // switch case for goals menu
                    {
                        goalInput = goalChoice.GoalChoice();
                        switch (goalInput)
                        {
                            case 1:
                                // Simple Goal
                                // Console.WriteLine("\nSimple Goals\n");
                                Console.WriteLine("What is the name of your goal?  ");
                                string name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.WriteLine("What is a short description of your goal?  ");
                                string description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                Console.WriteLine("What is the amount of points associated with this goal?  ");
                                int points = int.Parse(Console.ReadLine());
                                SimpleGoal sGoal = new SimpleGoal("Simple Goal:", name, description, points, false);
                                goals.Add(sGoal);
                                goalInput = 4;
                                break;
                            case 2:
                                // Eternal Goal
                                // Console.WriteLine("Eternal Goals");
                                Console.WriteLine("What is the name of your goal?  ");
                                name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.WriteLine("What is a short description of your goal?  ");
                                description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                Console.WriteLine("What is the amount of points associated with this goal?  ");
                                points = int.Parse(Console.ReadLine());
                                EternalGoal eGoal = new EternalGoal("Eternal Goal:", name, description, points, false);
                                goals.Add(eGoal);
                                goalInput = 4;
                                break;
                            case 3:
                                // Checklist Goal
                                // Console.WriteLine("Checklist Goals");
                                Console.WriteLine("What is the name of your goal?  ");
                                name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.WriteLine("What is a short description of your goal?  ");
                                description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                Console.WriteLine("What is the amount of points associated with this goal?  ");
                                points = int.Parse(Console.ReadLine());
                                Console.WriteLine("How many times does this goal need to be accomplished for a bonus?  ");
                                int bonusNumber = int.Parse(Console.ReadLine());
                                Console.WriteLine("What is the bonus for accomplishing it that many times?  ");
                                int bonusPoints = int.Parse(Console.ReadLine());
                                ChecklistGoal clGoal = new ChecklistGoal("Check List Goal:", name, description, points, false, bonusNumber, bonusPoints);
                                goals.Add(clGoal);
                                goalInput = 4;
                                break;
                            case 4:
                                // Exit
                                break;
                            default:
                                Console.WriteLine($"\nSorry the option you entered is not valid.");
                                break;
                        }
                    }
                    break;
                case 2:
                    // List Goals
                    // This will clear the console
                    Console.Clear();

                    Console.WriteLine("\nYour Goals are:");
                    // Loop though goals list
                    int index = 1;
                    foreach (Goal goal in goals)
                    {
                        goal.ListGoal(index);
                        index = index + 1;
                    }
                    break;
                case 3:
                    // Save Goals
                    Console.Write("What is your name for this goal file?  ");
                    string userInput = Console.ReadLine();
                    string userFileName = userInput + ".txt";

                    using (StreamWriter outputFile = new StreamWriter(userFileName))
                    {
                        foreach (Goal g in goals)
                        {
                            outputFile.WriteLine(g.SaveGoal());
                        }
                    }

                    break;
                case 4:
                    // Load Goals
                    Console.Write("What is the name of your goal file?  ");
                    userInput = Console.ReadLine();
                    userFileName = userInput + ".txt";

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
                                goals.Add(sGoal);
                            }
                            if (entries[0] == "Eternal Goal:")
                            {
                                EternalGoal eGoal = new EternalGoal(type, name, description, points, status);
                                goals.Add(eGoal);
                            }
                            if (entries[0] == "Check List Goal:")
                            {
                                int bonusNumber = int.Parse(entries[5]);
                                int bonusPoints = int.Parse(entries[6]);
                                ChecklistGoal clGoal = new ChecklistGoal(type, name, description, points, status, bonusNumber, bonusPoints);
                                goals.Add(clGoal);
                            }
                        }
                    }

                    break;
                case 5:
                    // Record Event
                    Console.WriteLine("record events");

                    break;
                case 6:
                    // Quite
                    Console.WriteLine("\nThank you for using the Eternal Quest Program!\n");
                    break;
                default:
                    Console.WriteLine($"\nSorry the option you entered is not valid.");
                    break;
            }
        }
    }
}