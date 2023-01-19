using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._jobTitle = "Custumer Services";
        job1._company = "Oracle";
        job1._startYear = 2018;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._jobTitle = "Computer Support";
        job2._company = "Sony";
        job2._startYear = 2020;
        job2._endYear = 2021;

        Resume myResume = new Resume();
        myResume._name = "Juan Perez";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayJobDetails();

    }
}