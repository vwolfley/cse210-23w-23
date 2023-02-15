using System;

class Program
{
    static void Main(string[] args)
    {
       
        Assignment assig1 = new Assignment();
        assig1.SetStudentName("Samuel Bennett");
        assig1.SetTopic("Multiplication");
        
        Console.WriteLine(assig1.GetSummary());

        MathAssignment math = new MathAssignment();
        math.SetStudentName("Roberto Rodriquez");
        math.SetTopic("Fractions");
        math.SetTextBookSection("Section 7.3");
        math.SetProblems("Problems 8-19");

        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        WritingAssignment write = new WritingAssignment();
        write.SetTitle("The Causes of World War II");
        write.SetStudentName("Mary Waters");
        write.SetTopic("European History");

        Console.WriteLine(write.GetSummary());
        Console.WriteLine(write.GetWritingInformation());



    }
}