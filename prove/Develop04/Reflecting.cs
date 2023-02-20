


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

    // public Reflecting(int duration) : base(duration)
    // {}

    // public List<string> PromptReflectList{ get { return _promptListReflect;}}
    // public List<string> ReflectingQuestionList{ get { return _reflectingQuestionList;}}

    public string GetRandomPromptReflect()
    {
        // From the list return one prompt as string
        _promptListReflect = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        // Count how many prompt are in the list a get one random by index 
        int i = rnd.Next(_promptListReflect.Count);
        string rndPrompt = _promptListReflect[i];
        return rndPrompt;
    }

    public void DisplayPrompt(string prompt)
    {
        // Recieve a prompt as string
        // and display a msgs
        Console.WriteLine($"Consider the following prompt:\n\n--- {prompt} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue\n");
        Thread.Sleep(3000);
        Console.ReadLine();
        DisplaySpinner();

        // Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.\n");
        Console.Write("You may begin in: ");
        Thread.Sleep(3000);
        DisplayCountdown();
        Console.WriteLine();
        Console.Clear();
    }

    public List<string> GetRandomQuestion()
    {
        // From the list return questions by the duration
        _reflectingQuestionList = new List<string>() 
        { 
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        // in base of the duration return questions as list
        int quantity = 0;
        List<string> questionsSelected = new List<string>();

        if (base.Duration >=5 && base.Duration <=30)
        {
            quantity = 2;
        }
        else if (base.Duration > 30) //&& base.Duration >=30
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

    public void DisplayQuestions(List<string> questions)
    {
        // Recieve a question list and display by delay each one by behind
        // in base of the duration divide the duration by list of questions
        int delay = 0;
        if (base.Duration >=5 && Duration <=30)
        {
            delay = Duration/2;
        }
        else if (Duration > 30) //&& base.Duration >=30
        {
            delay = Duration/3;
        }
        else
        {
            delay = Duration;
        }

        //Console.WriteLine("Get Duration " + Duration);
        //DisplaySpinner();
        foreach (string question in questions)
        {
            Console.Write($"> {question} ");
            Thread.Sleep(delay * 1000);
            Console.WriteLine();
        }
    }

    public void Start()
    {
        // Start the activity Reflect
        Console.Clear();
        GetStartMsg();
        InputDuration();

        Console.Clear();
        GetReadyMsg();
        DisplaySpinner();
        // 

        DisplayPrompt(GetRandomPromptReflect());
        DisplayQuestions(GetRandomQuestion());
        Console.WriteLine();

        GetEndtMsg();
    }
}