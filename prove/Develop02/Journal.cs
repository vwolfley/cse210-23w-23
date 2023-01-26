using System;


public class Journal
{
    // variables
    public List<JournalEntry> _journal = new List<JournalEntry>();
    private string fileName = "MyJournal.txt";
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
        string userFileName = Console.ReadLine();

        if (!File.Exists(userFileName))
        {
            using (StreamWriter outputFile = new StreamWriter(userFileName))
            {
                File.CreateText(userFileName);
                outputFile.WriteLine("************** Journal Entries **************\n");
                foreach (JournalEntry journalEntry in _journal)
                {
                    outputFile.WriteLine($"{journalEntry._dateTime}");
                    outputFile.WriteLine($"Prompt: {journalEntry._journalPrompt}");
                    outputFile.WriteLine($"Entry: {journalEntry._journalEntry}\n");
                }
            }
            Console.Write("\n*** MyJournal.txt has been created! ***\n");
        }
        else
        {
            Console.Write("\n*** MyJournal.txt already exits. ***\n");
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
    }

    public void LoadJournalFile()
    // Method to check if txt file is created and load it
    {
        Console.Write("What your file name? ");
        string userFileName = Console.ReadLine();

        if (File.Exists(userFileName))
        {
            string text = File.ReadAllText(userFileName);
            Console.WriteLine($"\n{text}");
        }
    }

}