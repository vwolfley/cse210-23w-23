using System;

public class MathAssignment : Assignment
{
    // Attributes 
    private string _textBookSection = "";
    private string _problems = "";

    // Constructors
    public string GetTextBookSection()
    {
        return _textBookSection;
    }
    public void SetTextBookSection(string textBookSection)
    {
        _textBookSection = textBookSection;
    }
    public string GetProblems()
    {
        return _problems;
    }
    public void SetProblems(string problems)
    {
        _problems = problems;
    }


    // Methods
    public string GetHomeworkList()
    {
        return $"{_textBookSection} - {_problems}";
    }


}
