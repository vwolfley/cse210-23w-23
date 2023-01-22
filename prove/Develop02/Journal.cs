using System;


public class Journal
{
    // The C# convention is to start member variables with an underscore _
    public List<JournalEntry> _journal = new List<JournalEntry>();


    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public Journal()
    {
    }

    // A method that displays the person's full name as used in eastern 
    // countries or <family name, given name>.
    public void Display()
    {
        Console.WriteLine("\n************** Journal Entries **************");
        foreach (JournalEntry journal in _journal)
        {
            journal.Display();
        }
    }

}