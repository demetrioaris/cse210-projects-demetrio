


public class Breathing : Activity
{
    //private int _durationAct;
    public Breathing() : base(
        "Breathing",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
    )
    {   //this was for prove the display msg
        //Duration = Activity.InputDuration();
    }
    //public int Duration{ get{ return _durationAct;}}

    public Breathing(int duration) : base(duration)
    {}

    public void DisplayBreathinActivity()
    {
        int messageTime = 5 ;
        int numLoops = base.Duration / (2 * messageTime);

        string messageStart = "Breathe in...";
        //string messageHold = "Hold...";
        string messageEnd = "Now breathe out...";
        string[] messages = new string[numLoops * 3];
        for (int i = 0; i < numLoops; i++)
        {
            // display start message and countdown
            Console.Write(messageStart);
            DisplayCountdown();
            Console.WriteLine();
            /* display hold message and countdown
            Console.Write(messageHold);
            DisplayCountdown();
            Console.WriteLine();*/
            // display end message and countdown
            Console.Write(messageEnd);
            DisplayCountdown();
            Console.WriteLine();
            /* display hold message and countdown
            Console.Write(messageHold);
            DisplayCountdown();
            Console.WriteLine();*/
            // add blank line
            Console.WriteLine(" ");
        }
    }

    public void Start()
    {
        Console.Clear();
        base.GetStartMsg();
        InputDuration();

        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplaySpinner();
        Console.WriteLine();
        Console.WriteLine();

        DisplayBreathinActivity();

        base.GetEndtMsg();
    }
}