


public class Listing : Activity
{
    private List<string> _promptListListen;
    private string _response;
    private List<string> _listResponse;
    Random rnd = new Random();

    public Listing() : base
    (
        "Listening",
        "This Activity will help you reflect on the good things in your life by having you list as many things ass you can in a certain area."
    ){}
    // public Listing(int duration) : base(duration)
    // {}
    
    // public List<string> PromptListenList{ get { return _promptListListen;}}
    // public string Response{ get { return _response;}}
    // public List<string> ResponseList{ get { return _listResponse;}}


    public string GetRandomPromptListen()
    {
        // From the list return one prompt as string
        _promptListListen = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        };

        // Count how many prompt are in the list and get one random by index 
        int i = rnd.Next(_promptListListen.Count);
        string rndPrompt = _promptListListen[i];
        return rndPrompt;
    }

    public void DisplayPrompt(string prompt)
    {   
        // Recieve a prompt as string
        // and display a msgs
        Console.WriteLine($"List as many response you can to the following prompt:\n\n--- {prompt} ---\n\n");
        Console.Write("You may begin in: ");
        Thread.Sleep(3000);
        DisplayCountdown();
        Console.WriteLine(); // keep the countdown in the same line
    }

    public List<string> GetResponse()
    {

        _listResponse = new List<string>();
        ManualResetEvent mre = new ManualResetEvent(false); //  to signal when the duration-second timeout has elapsed.

        //Console.WriteLine("Enter responses (20 second timeout):");
        int num = Duration * 1000;
        //Console.WriteLine(Duration);
        System.Timers.Timer timer = new System.Timers.Timer(num); // it is milisecends
        timer.Elapsed += (sender, e) => 
        { 
            //Console.WriteLine("\nTimeout expired!");
            mre.Set();
        };
        timer.AutoReset = false;
        timer.Start();

        while (true)
        {
            Console.Write("> ");
            _response = Console.ReadLine();

            if (string.IsNullOrEmpty(_response))
            {
                Console.WriteLine("Response cannot be empty.");
            }
            else
            {
                _listResponse.Add(_response);
                //Console.WriteLine($"'{response}' added to list.");

                if (timer.Enabled)
                {
                    timer.Stop();
                    timer.Start();
                }
            }

            if (mre.WaitOne(0))
            {
                break;
            }
        }

        timer.Stop();
        return _listResponse;
    }
    
    public void StoreListResponse()
    {
        _listResponse = GetResponse(); // Here we start the GetResponse method
        // Count how many response are in the list and display the total
        int listCount = _listResponse.Count;
        Console.WriteLine();
        Console.WriteLine($"You listed {listCount} items!\n");
    }

    public void Start()
    {
        // Start the activity Listing
        Console.Clear();
        GetStartMsg();
        InputDuration();

        Console.Clear();
        GetReadyMsg();
        DisplaySpinner();
        Console.WriteLine();

        DisplayPrompt(GetRandomPromptListen());
        //DisplayInputResponse(); Here was my error, why display the get response twice
        Console.WriteLine();
        StoreListResponse();

        GetEndtMsg();
    }   
}