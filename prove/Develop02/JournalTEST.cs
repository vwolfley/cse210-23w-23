using System;

class JournalTEST
{
    private string myJournalFile = "MyJournal.json";
    public void Run()
    {
        // DisplayWelcome();
        // DisplayChoices();
    }
    private void DisplayWelcome()
    {
        Console.Write("\nWelcome to the Journal App!\n");
    }
    private int DisplayChoices()
    {
        string choices = @"
Please select one of the following choices:
1. Write
2. Display
3. Load
4. Save
5. Quit
What would you like to do? ";

        Console.WriteLine(choices);
        string userInput = Console.ReadLine();
        int action = int.Parse(userInput);
        return action;
    }
    private void DisplayGoodbye()
    {
        Console.WriteLine("\nThank you for using the Journal App!\n");
    }

    private void CreateJournalFile()
    {
        if (!File.Exists(myJournalFile))
        {
            File.Create(myJournalFile);
        }
    }

}