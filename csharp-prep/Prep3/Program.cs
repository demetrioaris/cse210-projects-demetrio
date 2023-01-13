using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Console.WriteLine("Guess My Number game");
        Console.WriteLine("***");

        //Console.WriteLine("What is the magic number? ");
        //string magicNumbInput = Console.ReadLine();
        //int magicNumb = int.Parse(magicNumbInput);
        //Console.WriteLine();
        Random randomGenerator = new Random();
        int magicNumb = randomGenerator.Next(1, 100);
        
        int guessNumb ;
        do{
            Console.WriteLine("What is your guess? ");
            string guessNumbInput = Console.ReadLine();
            guessNumb = int.Parse(guessNumbInput);

            if (guessNumb == magicNumb)
            {
            Console.WriteLine("You Guessed it!!!");
            }
            else if (guessNumb > magicNumb)
            {
            Console.WriteLine("Higher");
            }
            else
            {
            Console.WriteLine("Lower");
            }
        }
        
        while (guessNumb != magicNumb);
    }
}