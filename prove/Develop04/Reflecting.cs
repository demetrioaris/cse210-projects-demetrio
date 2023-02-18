


public class Reflecting : Activity
{
    private List<string> _promptListReflect;
    private List<string> _reflectingQuestionList;
    Random rnd = new Random();

    public Reflecting() : base
    (
        "Reflecting",
        "This activity will help you reflect on times in your life when you have shown strenght and resilience. This Will help you recognize the power you have and how you can use it in other aspects of your life."  
    ){}

    public Reflecting(int duration) : base(duration)
    {}

    public List<string> PromptReflectList{ get { return _promptListReflect;}}
    public List<string> ReflectingQuestionList{ get { return _reflectingQuestionList;}}

    public string GetRandomPromptReflect()
    {
        //Random rnd = new Random();
        _promptListReflect = new List<string>
        {
            "1", "2"
        };
        int i = rnd.Next(_promptListReflect.Count);
        string rndPrompt = _promptListReflect[i];

        return rndPrompt;
    }

    public void DisplayPrompt(string prompt)
    {
        Console.WriteLine($"Consider the following prompt:\n\n--- {prompt} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue");
        Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        DisplayCountdown();
        Console.WriteLine();
        Console.Clear();
    }

    public List<string> GetRandomQuestion()
    {
        //Random rnd = new Random();
        _reflectingQuestionList = new List<string>() 
        { 
            "uno", "dos", "tres", "cuatro", "cinco", "seis", 
            "siete", "ocho", "nueve", "diez" 
        };

        int quantity = 0;
        List<string> questionsSelected = new List<string>();

        if (base.Duration >=5 && base.Duration <=15)
        {
            quantity = 2;
        }
        else if (base.Duration > 15) //&& base.Duration >=30
        {
            quantity = 3;
        }
        else
        {
            quantity = 1;
        }

        while (questionsSelected.Count < quantity)
        {
            int iRnd = rnd.Next(_reflectingQuestionList.Count);
            string questionSelected = _reflectingQuestionList[iRnd];
            
            // validate if question is no repeated
            if (!questionsSelected.Contains(questionSelected))
            {
                questionsSelected.Add(questionSelected);
            }
        }
        return questionsSelected;
    }

    public void DisplayQuestions(List<string> Questions)
    {
        int delay = 0;
        if (base.Duration >=5 && base.Duration <=15)
        {
            delay = base.Duration/2;
        }
        else if (base.Duration > 15) //&& base.Duration >=30
        {
            delay = base.Duration/3;
        }
        else
        {
            delay = base.Duration;
        }

        Console.WriteLine("Get Duration " + Duration);
        foreach (string question in Questions)
        {
            Console.Write($"> {question} ");
            DisplaySpinner();
            Thread.Sleep(delay);
            Console.WriteLine();
        }
    }

    public void Start()
    {
        Console.Clear();
        base.GetStartMsg(); // Store contructor with the name and description
        InputDuration();

        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplaySpinner();
        Console.WriteLine();

        DisplayPrompt(GetRandomPromptReflect());
        DisplayQuestions(GetRandomQuestion());
        Console.WriteLine();

        base.GetEndtMsg();
    }
}