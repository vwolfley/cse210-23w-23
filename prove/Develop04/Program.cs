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
                    Console.Clear();
                    BreathingActivity breathing = new BreathingActivity("Breathing", 0);
                    breathing.GetActivityName();
                    breathing.GetActivityDescription();
                    int seconds = breathing.GetActivityTime();
                    breathing.GetReady(5);
                    breathing.Breathing(seconds);
                    breathing.GetDone();



                    // Animations spin = new Animations();
                    // string loadingText = "Loading....";
                    // Console.Write(loadingText);
                    // Console.CursorVisible = false;

                    // while (true)
                    // {
                    //     spin.Turn(loadingText);
                    //     // spin.SequencedMatrix(2, 0, 20, 10);
                    //     // spin.LoadingBar(loadingText, 23, 0);
                    //     spin.Ready();
                    // }



                    break;
                case 2:
                    //Start Reflecting Activity
                    Console.Clear();
                    ReflectingActivity reflecting = new ReflectingActivity("Reflecting", 0);
                    reflecting.GetActivityName();
                    reflecting.GetActivityDescription();
                    reflecting.GetActivityTime();

                    break;
                case 3:
                    //Start Listing Activity
                    Console.Clear();
                    ListingActivity listing = new ListingActivity("Listing", 0);
                    listing.GetActivityName();
                    listing.GetActivityDescription();
                    listing.GetActivityTime();

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