using System;


public class Journal
{
    // variables
    public List<JournalEntry> _journal = new List<JournalEntry>();
    private string fileName = "MyJournal.txt";


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
        // string fileName = "MyJournal.txt";

        if (!File.Exists(fileName))
        {
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                File.CreateText(fileName);
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
            using (StreamWriter outputFile = new StreamWriter(fileName, append: true))
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
         if (File.Exists(fileName))
        {
            string text = File.ReadAllText(fileName);
            Console.WriteLine($"\n{text}");
        }
    }

}