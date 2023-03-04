using System;

class Program
{
    static void Main(string[] args)
    {

        // This will clear the console
        Console.Clear();
        Console.Write("\n*** Welcome to the Eternal Quest Program ****\n");
        //Call MainMenu
        MainMenu choice = new MainMenu();


        int action = 0;
        while (action != 6)
        {
            // Ask for user input (1-6)
            action = choice.UserChoice();
            switch (action)
            {
                case 1:
                    // Create New Goal
                    GoalMenu goalChoice = new GoalMenu();
                    goalChoice.GoalChoice();

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