


public class MenuActivity
{
    public void MenuOptionsActivity() 
    {
        string [] listOptions = 
        {
            "Menu Options: ",
            "   1. Start breathing activity",
            "   2. Start reflecting activity",
            "   3. Start Listing activity",
            "   4. Quit"
        
        };
        foreach (string option in listOptions)
        {
            Console.WriteLine(option);
        }
    }

    public void DisplayOptionActivity()
    {
        string choose = "";
        do
        {
            Console.Clear();
            MenuOptionsActivity();
            Console.WriteLine("Select a choice from the menu:");
            choose = Console.ReadLine();
            switch(choose)
            {
                case "1":
                    Breathing breath = new Breathing();
                    breath.Start();
                    break;

                case "2":
                    Reflecting reflect = new Reflecting();
                    reflect.Start();
                    break;

                case "3":
                    Listing listen = new Listing();
                    listen.Start();
                    break;

                case "4":
                    Console.Clear();
                    Console.WriteLine("Bye!!! -- Have nice day");
                    Console.ReadLine();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("This is not a valid option");
                    Console.WriteLine(" ");
                    Console.WriteLine("Press Enter to return the List of option");
                    Console.ReadLine();
                    DisplayOptionActivity();
                    break;

            }
        } while (choose != "4");
    }
}