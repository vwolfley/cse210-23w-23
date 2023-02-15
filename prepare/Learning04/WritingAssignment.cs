using System;

public class WritingAssignment : Assignment
{
    // Attributes 
    private string _title = "";

    // Constructors
    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }


    // Methods
    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }


}
