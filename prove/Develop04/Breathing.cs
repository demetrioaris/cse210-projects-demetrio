


public class Breathing : Activity
{
    // return the name and description to the base class
    public Breathing() : base(
        "Breathing",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
    )
    {}

    // public Breathing(int duration) : base(duration)
    // {}

    public void DisplayBreathinActivity()
    {
        // Display the activity breathe in and breath out
        int messageTime = 5; // 5 second by breath msg 
        int numLoops = Duration / (2 * messageTime);

        string breatheIn = "Breathe in...";
        string messageHold = "Hold...";
        string breatheOut = "Now breathe out...";
        string[] messages = new string[numLoops * 3];
        for (int i = 0; i < numLoops; i++)
        {
            // display start message and countdown
            Console.Write(breatheIn);
            DisplayCountdown();
            Console.WriteLine();
            //display hold message and countdown
            Console.Write(messageHold);
            DisplayCountdown();
            Console.WriteLine();
            // display end message and countdown
            Console.Write(breatheOut);
            DisplayCountdown();
            Console.WriteLine();
            //display hold message and countdown
            Console.Write(messageHold);
            DisplayCountdown();
            Console.WriteLine();
            // add blank line
            Console.WriteLine(" ");
        }
    }

    public void Start()
    {
        // Start the activity Breath
        Console.Clear();
        GetStartMsg();
        InputDuration();

        Console.Clear();
        GetReadyMsg();
        DisplaySpinner();
        Console.WriteLine();
        
        DisplayBreathinActivity();

        GetEndtMsg();
    }
}