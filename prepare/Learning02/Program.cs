using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._startYear = 2012;
        job1._endYear = 2018;
        // job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Senior Software Engineer";
        job2._company = "Twitter";
        job2._startYear = 2018;
        job2._endYear = 2022;
        // job2.Display();


        Resume myResume = new Resume();
        myResume._name = "Vern Wolfley";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}