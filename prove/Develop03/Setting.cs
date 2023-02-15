using System.Text;
using System.Text.RegularExpressions;

public class Setting
{
    
    public void ListOptions()
    {
        string[] listOption = 
        {
            "Welcome to the Scripture Memorizer Program!",
            "Please select one of the following choices:",
            "1) Choose a Scripture & start to hide words",
            "2) Introduce a new Scripture to the current List",
            "3) Exit the Program"
        };

        foreach (string option in listOption)
        {
            Console.WriteLine(option);
        }
    }

    public void RunSetting() 
    {
        string choose = "";

        do
        {
            Console.Clear();
            ListOptions();
            Console.WriteLine(" ");
            Console.WriteLine("What would you like to do?");
            choose = Console.ReadLine();
            switch(choose)
            {
                case "1":
                    Console.Clear();
                    Word word = new Word();
                    word.ScriptureChoose();
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("This function is out services");
                    Console.WriteLine("We are working hard to restore");
                    Console.WriteLine("Thank for patience");
                    Console.WriteLine("Press Enter to return the List of option");
                    Console.ReadLine();
                    //RunSetting();
                    break;

                case "3":
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
                    RunSetting();
                    break;

            }
        } while (choose != "3");
    }

    
}


