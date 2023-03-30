using System;

public abstract class Menu
{
    // Attributes
    private string _menu;
    private string _userInput;
    private int _userChoice = 0;
    private int _action = 0;


    // Constructors
    public Menu(string menu)
    {
        _menu = menu;
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

    // Methods
    public abstract int UserChoice();

    public abstract void MenuChoice();
    

}