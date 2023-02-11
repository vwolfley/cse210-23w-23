using System;

// A code template for the category of things known as 
public class Scripture
{
    // variables
    public List<Scripture> _scripture = new List<Scripture>();
    private string _fileName = "DataText.txt";
    private string _key;
    private string _text;


    // Methods
    public void LoadScriptures()
    {
        List<string> readText = File.ReadAllLines(_fileName).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();

        foreach (string line in readText)
        {
            string[] entries = line.Split(";");

            Scripture entry = new Scripture();

            entry._key = entries[0];
            entry._text = entries[6];

            _scripture.Add(entry);
        }
    }

    public void ScriptureDisplay()
    {
        foreach (Scripture item in _scripture)
        {
            item.ShowScripture();
        }
    }

    public void ShowScripture()
    {
        Console.WriteLine($"\n{_text}");
    }
    public void HideWords()
    {

    }
    public void GetRenderedText()
    {

    }
    public void IsCompletelyHidden()
    {

    }


}