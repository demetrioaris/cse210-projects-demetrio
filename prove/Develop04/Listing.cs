


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
    public Listing(int duration) : base(duration)
    {}
    
    public List<string> PromptListenList{ get { return _promptListListen;}}
    public string Response{ get { return _response;}}
    public List<string> ResponseList{ get { return _listResponse;}}


    public string GetRandomPromptListen()
    {
        //Random rnd = new Random();
        _promptListListen = new List<string>
        {
            "1", "2"
        };
        int i = rnd.Next(_promptListListen.Count);
        string rndPrompt = _promptListListen[i];

        return rndPrompt;
    }

    public void DisplayPrompt(string prompt)
    {
        Console.WriteLine($"List as many response you can to the following prompt:\n\n--- {prompt} ---");
        Console.WriteLine();
        Console.Write("You may begin in: ");
        DisplayCountdown();
        Console.WriteLine(); // keep the countdown in the same line
    }
    public void StoreListResponse()
    {
        _listResponse = DisplayInputResponse();
        int listCount = _listResponse.Count;
        Console.WriteLine($"You listed {listCount} items!");

    }

    List<string> DisplayInputResponse() 
    {
        //Console.WriteLine("Get Duration " + base.Duration);
        //_listResponse = DisplayInputResponse();
        //List<string> lista = new List<string>();
        System.Timers.Timer temp = new System.Timers.Timer(Duration * 1000);
        temp.AutoReset = false;
        
        // Console.Write("> ");
        // _response = Console.ReadLine();
        temp.Start();

        while (true)
        {
            Console.Write("> ");
            _response = Console.ReadLine();

            if (string.IsNullOrEmpty(_response))
            {   
                
                break;
            }
            Console.WriteLine("> " + _response);
            _listResponse.Add(_response);
        }

        temp.Stop();
        temp.Dispose();
        return _listResponse;
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

        DisplayPrompt(GetRandomPromptListen());
        DisplayInputResponse();
        Console.WriteLine();

        base.GetEndtMsg();
    }   
}