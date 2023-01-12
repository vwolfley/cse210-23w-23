using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");

        /*
        Assignment
        Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0.
        Core Requirements
        1. Compute the sum, or total, of the numbers in the list.
        2. Compute the average of the numbers in the list.
        3. Find the maximum, or largest, number in the list.
        */

        string userNumber;
        int number = -1;

        List<int> numbers = new List<int>();

        while (number != 0)
        {
            Console.Write("Enter number: ");
            userNumber = Console.ReadLine();
            number = int.Parse(userNumber);
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");

        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");











    }
}