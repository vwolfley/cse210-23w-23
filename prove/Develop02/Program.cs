using System;

class Program
{
    static void Main(string[] args)
    {
        // Journal myJournal = new Journal();
        // myJournal.Run();

        int[] validNumbers = { 1, 2, 3, 4, 5 };
        int action = 0;
        Console.Write("\nWelcome to the Journal App!\n");

        Journal journal = new Journal();


        while (action != 5)
        {
            // Ask for user input (1-5)
            //Call Choices
            action = Choices();

            switch (action)
            {
                case 1:
                    // Code Here
                    string dateInfo = GetDateTime();
                    string prompt = JournalPrompts();
                    JournalEntry entry = new JournalEntry();
                    entry._dateTime = dateInfo;
                    entry._journalPrompt = prompt;

                    Console.Write(":>> ");
                    string userEntry = Console.ReadLine();
                    entry._journalEntry = userEntry;

                    journal._journal.Add(entry);

                    // Console.WriteLine("Success Choice 1!");
                    break;
                case 2:
                    // Code Here
                    journal.Display();
                    // Console.WriteLine("Success Choice 2!");
                    break;
                case 3:
                    // Code Here
                    Console.WriteLine("Success Choice 3!");
                    break;
                case 4:
                    // Code Here
                    Console.WriteLine("Success Choice 4!");
                    break;
                case 5:
                    // Code Here
                    Console.WriteLine("\nThank you for using the Journal App!\n");
                    break;
                default:
                    Console.WriteLine("\nSorry that is not a valid choice!");
                    break;
            }
        }


    }

    static string JournalPrompts()
    {
        var random = new Random();

        var prompt = new List<string> {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "List the places I have been to today.",
            "What was the best idea you had today?",
            "List the 3 things you are grateful for today and why."
        };
        int index = random.Next(prompt.Count);
        string journalPrompt = prompt[index];
        Console.WriteLine($"\n{journalPrompt}");

        return journalPrompt;
    }

    static int Choices()
    {
        string choices = @"
Please select one of the following choices:
1. Write
2. Display
3. Load
4. Save
5. Quit
What would you like to do? ";

        Console.Write(choices);
        string userInput = Console.ReadLine();
        int action = int.Parse(userInput);

        return action;
    }

    static string GetDateTime()
    {
        DateTime now = DateTime.Now;
        string currentDateTime = now.ToString("F");
        // Console.WriteLine(now.ToString("F"));
        // Displays Saturday, March 01, 2008 7:00:00 AM
        return currentDateTime;
    }



}