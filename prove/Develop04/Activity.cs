


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

    // public Activity()
    // {}

    public int Duration { get { return _duration; }} // return 
    public string Name { get{ return _activityName;}}
    public string Description{ get{ return _activityDescription;}}

    public void GetStartMsg()
    {
        // Display the start msg
        Console.Clear();
        DisplaySpinner();
        Console.Clear();
        Console.WriteLine($"Welcome to the {Name} Activity.\n\n{Description}\n");
    }

    public int InputDuration()
    {
        // Ask the user to introduce duration time
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

    public void GetEndtMsg()
    {
        // Display the final msg
        Console.WriteLine($"Well done!!!");
        Thread.Sleep(3000);
        DisplaySpinner();
        Console.WriteLine($"\nYou have completed another {_duration.ToString()} seconds of the {Name} Activity.");
        Thread.Sleep(3000);
        DisplaySpinner();

        // Return to the Menu
        MenuActivity menu = new MenuActivity();
        menu.DisplayOptionActivity();
    }

    public static void DisplaySpinner()
    {   
        // use to display a spinner, get from internet
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
        Console.WriteLine();
    }

    public static void DisplayCountdown()
    {
        // Use to display a Coundown 5 to 1
        for (int i = 5; i >= 1; i--) {
            Console.Write(i + " ");
            Thread.Sleep(1000); // pause for 1 second
            Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
        }
        Console.Write(" ");
    }

    public static void Loading()
    {   
        // Use to display a Loanding... 
        DateTime startTime = DateTime.Now;
        int startingLine = Console.CursorTop; // keep the position in "Loanding"
        while (true)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write("Loading");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(1000); // wait for seconds
                }
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, Console.CursorTop);
            }
            Console.CursorLeft = 0;  // Move the cursor to the beginning of the line
            Console.Write(new string(' ', Console.WindowWidth));  // clear current line

            // Move the cursor to the previous line if we are not on the first line
            if (Console.CursorTop > startingLine)
            {
                Console.CursorTop--;
            }

            // Exit loop after 6 seconds
            if ((DateTime.Now - startTime).TotalSeconds >= 6)
            {
                break;
            }
        }
    }

    public static void GetReadyMsg()
    {   
        // It is the same as Loanding... but in this case it is Get ready...
        DateTime startTime = DateTime.Now;
        int startingLine = Console.CursorTop;
        while (true)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write("Get ready");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(1000); 
                }
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, Console.CursorTop);
            }
            Console.CursorLeft = 0;  
            Console.Write(new string(' ', Console.WindowWidth));  

            if (Console.CursorTop > startingLine)
            {
                Console.CursorTop--;
            }

            if ((DateTime.Now - startTime).TotalSeconds >= 6)
            {
                break;
            }
        }
    }

    // public void StoreDuration()
    // {
    //     List<int> durationList = new List<int>();
    //     durationList.Add(_duration);
    //     int sum = durationList.Sum();
    //     Console.WriteLine($"The total time you spent  {sum} sec");
    // }
}