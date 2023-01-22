using System;
using System.IO;

class Program
{

    static void Main(string[] args)
    {
        // Journal myJournal = new Journal();
        // myJournal.Run();


        int[] validNumbers = { 1, 2, 3, 4, 5 };
        int action = 0;
        Console.Write("\n**** Welcome to the Journal App ****\n");
        // Create new journal reference/list
        Journal journal = new Journal();


        while (action != 5)
        {
            // Ask for user input (1-5)
            //Call Choices
            action = Choices();

            switch (action)
            {
                case 1:
                    // Write Journal Entry
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
                    // Display Journal Entries
                    journal.Display();
                    // Console.WriteLine("Success Choice 2!");
                    break;
                case 3:
                    // Load

                    // Console.WriteLine("Success Choice 3!");
                    break;
                case 4:
                    // Save
                    CreateJournalFile();
                    // string AddEntry = journal.Display();
                    // AddJournalEntry(AddEntry);
                    // Console.WriteLine("Success Choice 4!");
                    break;
                case 5:
                    // Quite
                    Console.WriteLine("\nThank you for using the Journal App!\n");
                    break;
                default:
                    Console.WriteLine("\nSorry that is not a valid choice!");
                    break;
            }
        }


    }

    static string JournalPrompts()
    // Method to display random journal prompts to user
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
            "List the 3 things you are grateful for today and why.",
            "What was the most outrageous thing you did today?",
            "What was the best meal of the day today and what was it?",
            "Who made you feel good today?",
            "What did you learn today?",
            "What is the funniest thing that happened today?",
            "If you could become an expert in any subject or activity, what would it be?",
            "What would you buy today if money were no object?",
            "How did you procrastinate on important tasks today?",
            "What scripture just popped into your head right now?",
            "What is something that made you laugh today?",
            "Who made your day better today?",
            "What is one thing you want to remember from today?",
            "What steps did you take today towards a goal you’re working on?",
            "How can you make tomorrow (even) better than today?",
            "What went well today?",
            "What’s a simple pleasure in your life that you are thankful for?",
            "How did you show love to someone today?",
            "How would you describe your spirituality today?",
            "What was your magic power today?",
            "Identify three times that you felt challenged today.",
            "What do I need to let go of today?",
            "What do you need the most right now?",
            "If you could only accomplish three things tomorrow, what would they be?",
            "What was the most peaceful moment during the day?",
            "Would you change any of the decisions you made today?",
            "What frightened you today?",
            "Who do you wish you had talked to today? What would you say?",
            "If you’d had another hour during the day, how would you have spent it?",
            "Reflect on how your body feels. Sore, Stressed, Tired, Energized",
            "Did you read a book today? If so what?",
            "Did you watch a movie today? If so what?",
            "Did you watch a TV show today? If so what?"
        };
        int index = random.Next(prompt.Count);
        string journalPrompt = prompt[index];
        Console.WriteLine($"\n{journalPrompt}");

        return journalPrompt;
    }


    static int Choices()
    // Method to display choices to user
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
    // Method to get the date and time for journal record
    {
        DateTime now = DateTime.Now;
        string currentDateTime = now.ToString("F");
        // Console.WriteLine(now.ToString("F"));
        // Displays Saturday, March 01, 2008 7:00:00 AM
        return currentDateTime;
    }

    static void CreateJournalFile()
    // Method to check if txt file is created if not create one
    {
        string MyJournalFile = "MyJournal.txt";

        if (!File.Exists(MyJournalFile))
        {
            File.CreateText(MyJournalFile);
        }
    }

    static void AddJournalEntry()
    // Method to add entry to text file
    {
        string MyJournalFile = "MyJournal.txt";
        File.AppendAllText(MyJournalFile, "");
    }


}