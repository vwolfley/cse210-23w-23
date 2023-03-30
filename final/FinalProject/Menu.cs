using System;

public abstract class Menu
{
    // Attributes
    protected string _menu;
    protected string _userInput;
    protected int _userChoice = 0;
    protected int _action = 0;
    protected string _wordFileName;


    // Constructors
    public Menu()
    {

    }
    public string GetMenu()
    {
        return _menu;
    }
    public string GetUserInput()
    {
        return _userInput;
    }
    public int GetUserChoice()
    {
        return _userChoice;
    }
    public int GetAction()
    {
        return _action;
    }
     public string GetWordFileName()
    {
        return _wordFileName;
    }

    // Methods
    public abstract int UserChoice();
    public abstract void MenuChoice();

}