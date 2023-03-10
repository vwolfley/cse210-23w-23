using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

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
                                Console.WriteLine("\nSimple Goals\n");
                                Console.WriteLine("\nSimple Goals\n");

                                break;
                            case 2:
                                // Eternal Goal
                                Console.WriteLine("Eternal Goals");
                                break;
                            case 3:
                                // Checklist Goal
                                Console.WriteLine("Checklist Goals");
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
                    Console.WriteLine("list goals");

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