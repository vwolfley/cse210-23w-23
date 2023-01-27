using System;

// A code template for the category of things known as 
public class JournalEntry
{
    // The C# convention is to start member variables with an underscore _
    public string _entryNumber = "";
    public string _dateTime = "";
    public string _journalPrompt = "";
    public string _journalEntry = "";
    public string _journalFile = "";


    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public JournalEntry()
    {
    }

    // A method that displays 
    public void Display()
    {
        Console.WriteLine($"\n#: {_entryNumber}");
        Console.WriteLine($"Date: {_dateTime}");
        Console.WriteLine($"Prompt: {_journalPrompt}");
        Console.WriteLine($"Entry: {_journalEntry}");
    }

}