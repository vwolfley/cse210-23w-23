using System;

// A code template for the category of things known as Job. The
// responsibility of a Job is to hold and display personal employment information.
public class JournalEntry
{
    // The C# convention is to start member variables with an underscore _
    public int _entryNumber = 0;
    public string _dateTime = "";
    public string _journalPrompt = "";
    public string _journalEntry = "";


    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public JournalEntry()
    {
    }

    // A method that displays the person's full name as used in eastern 
    // countries or <family name, given name>.
    public void Display()
    {
        
        Console.WriteLine($"\n{_dateTime}");
        Console.WriteLine($"Prompt: {_journalPrompt}");
        Console.WriteLine($"Entry: {_journalEntry}");
    }

}