


using System.Diagnostics;

public class Activity
{
    private int _duration;
    private string _activityName;
    private string _activityDescription;
    
    public Activity(string name, string description)
    {
        _activityName = name;
        _activityDescription = description;
        
    }
    public Activity(int duration)
    {
        _duration = InputDuration();
    }

    public int Duration { get { return _duration; }} // return 
    public string Name { get{ return _activityName;}}
    public string Description{ get{ return _activityDescription;}}
    
    /*
    public string GetActivity()
    {
        //Get the choose of the user
    }*/

    public void GetStartMsg()
    {
        Console.WriteLine($"Welcome to the {Name} Activity.\n\n{Description}\n");
    }//
//
    public int InputDuration()
    {
        Console.WriteLine("How long, in second, would you like for your secction?");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int durationInput))
        {
            // Validate user input and convert to an integer
        _duration = durationInput;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a whole number.");
        }
        return _duration;
    }
//

    public void GetEndtMsg()
    {
        Console.WriteLine($"Well done!!");
        DisplaySpinner();
        Console.WriteLine($"\nYou have completed another {_duration.ToString()} seconds of the {Name} Activity.");
        DisplaySpinner();
        MenuActivity menu = new MenuActivity();
        menu.DisplayOptionActivity();
    }

    public static void DisplaySpinner()
    {   
        //Console.WriteLine("Get ready... \n");
        char[] spinnerSymbols = { '/', '-', '\\', '|' };
        int spinnerIndex = 0;
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.Elapsed < TimeSpan.FromSeconds(5)) {
            Console.Write(spinnerSymbols[spinnerIndex] + " ");
            spinnerIndex = (spinnerIndex + 1) % spinnerSymbols.Length;
            Thread.Sleep(100); // pause for 100 milliseconds
            Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
        }
        Console.Write(" ");
        stopwatch.Stop();
    }
//
    public static void DisplayCountdown()
    {
        //Console.Write("");
        for (int i = 5; i >= 1; i--) {
            Console.Write(i + " ");
            Thread.Sleep(1000); // pause for 1 second
            Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
        }
        Console.Write(" ");
    }
}