using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation4 World!");
        List<Activity> activities = new List<Activity>();

        Running a1 = new Running("05 Jan 2023", 15, 5);
        activities.Add(a1);

        StationayBicycles a2 = new StationayBicycles("22 Jun 2023", 30, 10);
        activities.Add(a2);

        Swimming a3 = new Swimming("10 Apr 2023", 5, 4);
        activities.Add(a3);

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
        // Swimming s1 = new Swimming("10 Apr 2023", 30, 4);
        // Console.WriteLine(s1.ActivityDistance());
    }
}