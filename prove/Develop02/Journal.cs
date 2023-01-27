using System;


public class Journal
{
    // variables
    public List<JournalEntry> _journal = new List<JournalEntry>();
    // private string fileName = "MyJournal.txt";
    private string _userFileName;


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
        _userFileName = userInput + ".txt";

        if (!File.Exists(_userFileName))
        {
            File.CreateText(_userFileName);
            Console.Write($"\n*** {_userFileName} has been created! ***\n");
            Console.Write("***  Your journal entries have been saved. ***\n");
            SaveJournalFile(_userFileName);
        }
        else
        {
            Console.Write($"\n*** {_userFileName} already exits. ***\n");
            Console.Write("***  Your journal entries have been added. ***\n");
            AppendJournalFile(_userFileName);
        }
    }
    public void SaveJournalFile(string _userFileName)
    {
        using (StreamWriter outputFile = new StreamWriter(_userFileName))
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

    public void AppendJournalFile(string _userFileName)
    {
        using (StreamWriter outputFile = new StreamWriter(_userFileName, append: true))
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
        _userFileName = userInput + ".txt";

        if (File.Exists(_userFileName))
        {
            string text = File.ReadAllText(_userFileName);
            Console.WriteLine($"\n{text}");

            string[] logFile = File.ReadAllLines(_userFileName);

            foreach (var value in logFile)
            {
                Console.WriteLine(value);
            }

            // _journal = new List<JournalEntry>(logFile);

            // List<JournalEntry> _journal = File.ReadAllLines(_userFileName).ToList();

        }
    }

}