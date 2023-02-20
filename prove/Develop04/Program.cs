
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop04 World!");
        MenuActivity run = new MenuActivity();
        run.DisplayOptionActivity();
        
        /*
            I declare the base class with the name Activity, and 3 derivates classes, and the aditional class Menu
            My derivates class are:
            1. Brething
            2. Reflecting
            3. Listing

            The base class has 3 private variables, because each derivate classes have then in common
            and 3 common methods are:
                1. GetStartMsg() return a void, and Display the Start Message, where getter the name and description
                2. InputDuration() return a int, Display a msg where asks the user to introduce a amount of time,
                    this value is stored in the contructor with paramete Duration, it's used to derivate class.
                3. GetEndMsg() return a void, Display the End Message, where getter the Duration and Name.
            
            Addinional methods to just display, DisplaySpinner() and DisplayCountdown() return void

            For the spinner I can create a variable time to display diferent period of time
         */
         // Activity.DisplaySpinner();
        // Activity.DisplayCountdown();

        // Breathing breath = new Breathing();
        // breath.Start();

        // Reflecting reflect = new Reflecting();
        // reflect.Start();

        // Listing listen = new Listing();
        // listen.Start();
    }
}
