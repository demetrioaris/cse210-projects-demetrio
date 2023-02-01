
public class Entry
{   
    public string _displayFile = "noSaveJournal.txt";
    private void ListOption()
    {   
        // The menu console
        //Console.Clear();  
        string [] _menu = {
            "Welcome to the journal Program!",
            "Please select one of the following choices",
            "1. Write",
            "2. Display",
            "3. Load",
            "4. Save",
            "5. Quit"
        };
        foreach(string _menuArr in _menu)
        {
            Console.WriteLine(_menuArr);
        }
    }
    public void DisplayMenu() {
        //loop for the  menu until is quit
        string _userInput = "";
        do {
            ListOption();
            Console.WriteLine("What would you like to do?");
            _userInput = Console.ReadLine();

            switch(_userInput)
            {
                case "1":
                    AddEntries();
                    break;
                case "2":
                    Journal _displayEntries = new Journal();
                    _displayEntries.DisplayNoSavefile();
                    break;
                case "3":
                    Journal _displayLoad = new Journal();
                    _displayLoad.DisplayLoad();
                    break;
                case "4":
                    Journal _save = new Journal();
                    _save.SaveWrite();
                    break;
                case "5":
                    Console.Clear();
                    Console.WriteLine("Bye!!! -- Have nice day");
                    Journal _clear = new Journal();
                    _clear.ClearNoSaveFile();
                    break;
                default:
                {
                    Console.WriteLine("This is not a valid option");
                    Console.Clear();
                    DisplayMenu();
                    break;
                }
            }
        }
        while (_userInput != "5");
    }
    public void AddEntries() 
    {
        Journal _createNew = new Journal();
        _createNew.CreateFile();
        DateTime _date = DateTime.Now;
        string _dateToday = _date.ToString("dd/MM/yyyy");
        Random _randomPrompt = new Random();
        string[] _listPrompt = {
            "How do you feel in your body right now? ",
            "What are you enjoying right now? ",
            "How did I see the hand of the Lord in my life today? ",
            "What about today made you smile? ",
            "Write down one good thing that happened to you today",
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
        int i = _randomPrompt.Next(_listPrompt.Length);
        string _prompt = _listPrompt[i];
        Console.WriteLine(_prompt);
        string _newEntry = Console.ReadLine();
        File.AppendAllText(_displayFile, $"Date: {_dateToday} - Prompt: {_prompt} \n{_newEntry}\n");
    } 
}    
