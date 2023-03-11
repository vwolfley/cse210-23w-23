using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
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
                                Console.WriteLine("What is a short description of your goal?  ");
                                string description = Console.ReadLine();
                                Console.WriteLine("What is the amount of points associated with this goal?  ");
                                int points = int.Parse(Console.ReadLine());
                                SimpleGoal sGoal = new SimpleGoal(name, description, points);
                                goals.Add(sGoal);
                                break;
                            case 2:
                                // Eternal Goal
                                // Console.WriteLine("Eternal Goals");
                                Console.WriteLine("What is the name of your goal?  ");
                                name = Console.ReadLine();
                                Console.WriteLine("What is a short description of your goal?  ");
                                description = Console.ReadLine();
                                Console.WriteLine("What is the amount of points associated with this goal?  ");
                                points = int.Parse(Console.ReadLine());
                                EternalGoal eGoal = new EternalGoal(name, description, points);
                                goals.Add(eGoal);
                                break;
                            case 3:
                                // Checklist Goal
                                // Console.WriteLine("Checklist Goals");
                                Console.WriteLine("What is the name of your goal?  ");
                                name = Console.ReadLine();
                                Console.WriteLine("What is a short description of your goal?  ");
                                description = Console.ReadLine();
                                Console.WriteLine("What is the amount of points associated with this goal?  ");
                                points = int.Parse(Console.ReadLine());

                                Console.WriteLine("How many times does this goal need to be accomplished for a bonus?  ");
                                int bonusNumber = int.Parse(Console.ReadLine());
                                Console.Write("What is the bonus for accomplishing it that many times?  ");
                                int bonusPoints = int.Parse(Console.ReadLine());

                                ChecklistGoal clGoal = new ChecklistGoal(name, description, points, bonusNumber, bonusPoints);
                                goals.Add(clGoal);


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
                    Console.WriteLine("Your Goals are:");
                    foreach (Goal g in goals)
                    {
                        g.ListGoal();
                    }
                    break;
                case 3:
                    // Save Goals
                    Console.WriteLine("save goals");

                    break;
                case 4:
                    // Load Goals
                    Console.WriteLine("load goals");

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