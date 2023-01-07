using System;

class Program
{
    static void Main(string[] args)
    {
        /* 
        Core Requirements
        Ask the user for their grade percentage, then write a series of if-elif-else statements to print out the appropriate letter grade. 
        (At this point, you'll have a separate print statement for each grade letter in the appropriate block.)

        Assume that you must have at least a 70 to pass the class. After determining the letter grade and printing it out. 
        Add a separate if statement to determine if the user passed the course, and if so display a message to congratulate them. 
        If not, display a different message to encourage them for next time.

        Change your code from the first part, so that instead of printing the letter grade in the body of each if, elif, or else block, 
        instead create a new variable called letter and then in each block, set this variable to the appropriate value. 
        Finally, after the whole series of if-elif-else statements, have a single print statement that prints the letter grade once.
        */

        /*
        Stretch Challenge
        Add to your code the ability to include a "+" or "-" next to the letter grade, such as B+ or A-. 
        For each grade, you'll know it is a "+" if the last digit is >= 7. You'll know it is a minus if 
        the last digit is < 3 and otherwise it has no sign.

        After your logic to determine the grade letter, add another section to determine the sign. 
        Save this sign into a variable. Then, display both the grade letter and the sign in one print statement.

        Hint: To get the last digit, you could divide the number by 10, and get the remainder. 
        You might refer back to the preparation material for Lesson 03 to see the operators and find the one that 
        does division and gives you the remainder.

        At this point, don't worry about the exceptional cases of A+, F+, or F-.

        Recognize that there is no A+ grade, only A and A-. 
        Add some additional logic to your program to detect this case and handle it correctly.

        Similarly, recognize that there is no F+ or F- grades, only F. 
        Add additional logic to your program to detect these cases and handle them correctly.
        */
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int gradePercent = int.Parse(userInput);

        string letter;
        // // Core Requirement #1 & #3
        if (gradePercent >= 90)
        {
            // Console.WriteLine("You earned an letter grade of A");
            letter = "A";
        }
        else if (gradePercent >= 80)
        {
            // Console.WriteLine("You earned an letter grade of B");
            letter = "B";
        }
        else if (gradePercent >= 70)
        {
            // Console.WriteLine("You earned an letter grade of C");
            letter = "C";
        }
        else if (gradePercent >= 60)
        {
            // Console.WriteLine("You earned an letter grade of D");
            letter = "D";
        }
        else
        {
            // Console.WriteLine("You earned an letter grade of F");
            letter = "F";
        }
        // Console.WriteLine($"You earned an letter grade of {letter}");

        // Stretch Challenge #1, #2, #3
        string fd = userInput.Substring(0, 1);
        int firstDigit = int.Parse(fd);

        string ld = userInput.Substring(1, 1);
        int lastDigit = int.Parse(ld);
        // testing
        // Console.WriteLine($"fd = {firstDigit}, ld = {lastDigit}");

        // Logic for plus or minus grade
        string ext;
        if ((firstDigit > 5 && firstDigit < 9) && lastDigit >= 7)
        {
            ext = "+";
        }
        else if ((firstDigit > 5 && firstDigit <= 9) && lastDigit < 3)
        {
            ext = "-";
        }
        else
        {
            ext = "";
        }

        Console.WriteLine($"You earned an letter grade of {letter}{ext}");

        // Core Requirement #2
        if (gradePercent >= 70)
        {
            Console.WriteLine("Congratulations you passed the test!");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass.  Better luck next time!");
        }

    }
}