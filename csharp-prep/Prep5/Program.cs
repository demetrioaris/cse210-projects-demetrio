using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        //*************************
        DisplayWelcome();
        
        string userNameInput = PromptUserName();
        int favNumbInput = PromptUserNumber();
        int sqrResult = SquareNumber(favNumbInput);

        DisplayResult(userNameInput, sqrResult);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please, Introduce your User Name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Please introduce your Favorite Number: ");
        int favNumb = int.Parse(Console.ReadLine());
        return favNumb;
    }

    static int SquareNumber(int sqrNumb)
    {
        int sqr = sqrNumb * sqrNumb;
        return sqr;
    }

    static void DisplayResult(string userName, int sqr)
    {
        Console.WriteLine($"{userName}, The square of your Number is {sqr}");
    }

}