using System;

// A code template for the category of things known as 
public class Reference
{
    // variables
    public List<Reference> _reference = new List<Reference>();
    private string _fileName = "DataText.txt";
    private string _key;
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;

    // Methods
    public void LoadReference()
    {
        List<string> readText = File.ReadAllLines(_fileName).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();

        foreach (string line in readText)
        {
            string[] entries = line.Split(";");

            Reference entry = new Reference();

            entry._key = entries[0];
            entry._book = entries[1];
            entry._chapter = int.Parse(entries[2]);
            entry._verseStart = int.Parse(entries[3]);
            entry._verseEnd = int.Parse(entries[4]);

            _reference.Add(entry);
        }
    }

    public void ReferenceDisplay()
    {
        foreach (Reference item in _reference)
        {
            // var test = item._verseEnd.Equals(0);
            // Console.WriteLine(test);
            if (item._verseEnd.Equals(0))
            {
                item.ReferenceOne();
            }
            else
            {
                item.ReferenceTwo();
            }
        }
    }

    public void ReferenceOne()
    {
        Console.WriteLine($"\n{_book} {_chapter}:{_verseStart}");
    }
    public void ReferenceTwo()
    {
        Console.WriteLine($"\n{_book} {_chapter}:{_verseStart}-{_verseEnd}");
    }
}

// add()
// delete()
// display()
// update()
// search()
