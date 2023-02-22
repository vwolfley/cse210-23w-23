using System;
using System.Diagnostics;

class Program
{

    static void Main(string[] args)
    {
        // This will clear the console
        Console.Clear();
        Console.Write("\n*** Welcome to the Mindfulness Program ****\n");
        //Call Choices
        Choices choice = new Choices();


        int action = 0;
        while (action != 4)
        {
            // Ask for user input (1-4)
            action = choice.UserChoice();
            switch (action)
            {
                case 1:
                    // Start Breathing Activity
                    Console.WriteLine("Success Choice 1!");
                    break;
                case 2:
                    //Start Reflecting Activity
                    Console.WriteLine("Success Choice 2!");
                    break;
                case 3:
                    //Start Listing Activity
                    Console.WriteLine("Success Choice 3!");
                    break;
                case 4:
                    // Quite
                    Console.WriteLine("\nThank you for using the Mindfulness Program!\n");
                    break;
                default:
                    Console.WriteLine($"\nSorry the option you entered is not valid.");
                    break;
            }
        }


    }

}