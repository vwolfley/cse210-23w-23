using System;


public class Journal
{
    // variables
    public List<JournalEntry> _journal = new List<JournalEntry>();
    // private string fileName = "MyJournal.txt";
    private string userFileName;


    // method
    public Journal()
    {
    }

    // A method that displays each journal entry
    public void Display()
    {
        Console.WriteLine("\n************** Journal Entries **************");
        foreach (JournalEntry journalEntry in _journal)
        {
            journalEntry.Display();
        }
    }

    public void CreateJournalFile()
    // Method to check if txt file is created if not create one
    {
        Console.Write("What your file name? ");
        string userInput = Console.ReadLine();
        userFileName = userInput + ".txt";

        if (!File.Exists(userFileName))
        {
            File.CreateText(userFileName);
            Console.Write($"\n*** {userFileName} has been created! ***\n");
            Console.Write("***  Your journal entries have been saved. ***\n");
            SaveJournalFile(userFileName);
        }
        else
        {
            Console.Write($"\n*** {userFileName} already exits. ***\n");
            Console.Write("***  Your journal entries have been added. ***\n");
            AppendJournalFile(userFileName);
        }
    }
    public void SaveJournalFile(string userFileName)
    {
        using (StreamWriter outputFile = new StreamWriter(userFileName))
        {
            outputFile.WriteLine("************** Journal Entries **************\n");

            foreach (JournalEntry journalEntry in _journal)
            {
                outputFile.WriteLine($"{journalEntry._dateTime}");
                outputFile.WriteLine($"Prompt: {journalEntry._journalPrompt}");
                outputFile.WriteLine($"Entry: {journalEntry._journalEntry}\n");
            }
        }

    }

    public void AppendJournalFile(string userFileName)
    {
        using (StreamWriter outputFile = new StreamWriter(userFileName, append: true))
        {
            foreach (JournalEntry journalEntry in _journal)
            {
                outputFile.WriteLine($"{journalEntry._dateTime}");
                outputFile.WriteLine($"Prompt: {journalEntry._journalPrompt}");
                outputFile.WriteLine($"Entry: {journalEntry._journalEntry}\n");
            }
        }
    }

    public void LoadJournalFile()
    // Method to check if txt file is created and load it into the list.  
    // This should replace any current info in the list
    {
        Console.Write("What your file name? ");
        string userInput = Console.ReadLine();
        userFileName = userInput + ".txt";

        if (File.Exists(userFileName))
        {
            string text = File.ReadAllText(userFileName);
            Console.WriteLine($"\n{text}");

            string[] logFile = File.ReadAllLines(userFileName);

            foreach (var value in logFile)
            {
                Console.WriteLine(value);
            }

            // _journal = new List<JournalEntry>(logFile);

            // List<JournalEntry> _journal = File.ReadAllLines(userFileName).ToList();

        }
    }

}