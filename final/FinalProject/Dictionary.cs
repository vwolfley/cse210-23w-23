using System;

public class Dictionary
{
    // Attributes
    private List<string> _dictionary = new List<string> ();
   
    // Constructors
    public List<string> GetList()
    {
        LoadWords();
        return _dictionary;
    }
    public void AddWord(string word)
    {
        _dictionary.Add(word);
    }
    // Methods

    public void LoadWords()
    {
        // Get file with words
        string fileName = "words2.txt";
        // Read file into dictionary
        string[] readText = File.ReadAllLines(fileName);

        // loop though text file for words
        foreach (string line in readText)
        {
            string entries = line;
            AddWord(entries);
        }
        // test to see if words loaded into word dictionary list
        // _dictionary.ForEach(Console.WriteLine);

    }
}