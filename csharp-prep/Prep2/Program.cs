using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("Please introduce your grade percentage: ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letter = "";
    
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your grades is {letter}");

        if (grade >= 70)
        {
          Console.WriteLine("Congratulation, you passed the courses!");
        }
        else
        {
          Console.WriteLine("Good try, better luck next time!");
        }
    }
}