using System;
using System.IO;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Call MainMenu
        MainMenu choice = new MainMenu();
        
        // Print welcome message
        choice.PrintWelcome();
        choice.MenuChoice();

    }
}
