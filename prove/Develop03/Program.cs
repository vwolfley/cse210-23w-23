using System;
using System.Text.Json;
using System.Text.Json.Serialization;



class Program
{
    static void Main(string[] args)
    {

        Reference reference = new Reference();
        reference.LoadReference();
        Scripture scripture = new Scripture();
        scripture.LoadScriptures();



        Console.Write("\n**** Welcome to the Scripture Memorizer App ****\n");

        int userChoice = 0;
        // Console.WriteLine(userChoice);

        while (userChoice != 3)
        {
            // Ask for user input (1,2,Q)
            //Call UserChoice
            userChoice = UserChoice();



            switch (userChoice)
            {
                case 1:
                    // Console.WriteLine("Success Choice 1!");
                    reference.ReferenceDisplay();
                    break;
                case 2:
                    // Console.WriteLine("Success Choice 2!");
                    scripture.ScriptureDisplay();
                    break;
                case 3:
                    Console.WriteLine("Success Choice 3!");
                    break;
                default:
                    Console.WriteLine($"\nSorry the option you entered is not valid.");
                    break;
            }

        }



    }

    static int UserChoice()
    // Method to display choices to user
    {
        string choices = @"
Main Menu
===========================================
Please select one of the following choices:
1. Display all references
2. Display all scriptures
Q. Quit
===========================================
What would you like to do?  ";

        Console.Write(choices);
        string userInput = Console.ReadLine();
        userInput.ToLower();
        int userChoice = 0;
        // This block catches any non integer values that are entered
        try
        {
            if (userInput == "q")
            {
                userInput = "3";
            }
            userChoice = int.Parse(userInput);
        }
        catch (FormatException)
        {
            userChoice = 0;
        }
        catch (Exception exception)
        {
            Console.WriteLine(
                $"Unexpected error:  {exception.Message}");
        }
        return userChoice;
    }


}