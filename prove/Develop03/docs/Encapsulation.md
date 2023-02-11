# Encapsulation - Articulate

- What is encapsulation and why is it important?

Encapsulation refers to the process of combining elements, like data and methods that operate on the data to create a new entity.  This new entity can then be used to hide, restrict, or protect the values and information to prevent users from accessing them directly.  In object-oriented programming, encapsulation is an attribute of object design.

Encapsulation in object-oriented programming has a few key benefits.  These benefits include hiding data, flexibility, and ease of reuse.  Users of the program will not have access to how the classes are being implemented or stored.  All they will have access to or know are the values that are being passed and initialized.  Encapsulation enables you to set variables as read or write only.  Encapsulation allows for the bundling of data and methods into a single package that can then more readily be changed and adapted to new requirements.

```
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
}
```

This class Scripture demonstrates encapsulation the list is public because it will need to be accessed in other areas but the other variables are private because they are only used by methods in this class hiding their value from users and other parts of the program keeping it clean from possible classing variable names.