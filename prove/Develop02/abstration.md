# Articulate the principle of abstraction.

## What is abstraction and why is it important?

Your response must:

- Explain the meaning of Abstraction
- Highlight a benefit of Abstraction
- Provide an application of Abstraction
- Use a code example of Abstraction from the program you wrote
- Thoroughly explain these concepts (this likely cannot be done in less than 100 words)


Abstraction is used to hide background details or any unnecessary implementation so that users only see the required information. By hiding unnecessary details from the user it enables the user to implement more complex logic on top of the provided abstraction without understanding or even thinking about all the hidden complexity.  Objects in an object-oriented programming language provide an abstraction that hides the internal implementation details.  You just need to know which methods of the object are available to call and which input parameters are needed to trigger a specific operation. You don’t need to understand how this method is implemented and which kinds of actions it has to perform to create the expected result.  An example of this would be in the python print() command.  You don't need to understand how it works, you just need to know how to use the print function.  In the journal program that we have been working on an example would be the class journal the user does not need to see how the journal list was created, they just want to see the journal entries.  


    public class Journal
    {
        // variables
        public List<JournalEntry> _journal = new List<JournalEntry>();


        // method
        public Journal()
        {
        }

        // A method that displays each journal entry
        public void Display()
        {
            Console.WriteLine("\n************** Journal Entries **************");
            foreach (JournalEntry journal in _journal)
            {
                journal.Display();
            }
        }

    }
