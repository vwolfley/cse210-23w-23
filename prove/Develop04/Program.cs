using System;
using System.Diagnostics;

class Program
{

    static void Main(string[] args)
    {
        // This will clear the console
        Console.Clear();
        Console.Write("\n*** Welcome to the Mindfulness Program ****\n");
        Choices choice = new Choices();
        choice.UserChoice();

        // Pausing
        Console.WriteLine("Going to sleep for a second...");

        Thread.Sleep(1000);

        Console.WriteLine("I'm back!!");

        

    
    }


   




}