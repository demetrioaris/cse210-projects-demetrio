using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List <int> numbs = new List<int>();
        int inputNumb = -1; 
        do{
            Console.WriteLine("Enter a list of number, Type 0 when finished");
            string userInput = Console.ReadLine();
            inputNumb = int.Parse(userInput);
            if (inputNumb != 0)
            {
                numbs.Add(inputNumb);
            }

        }
        while(inputNumb != 0);

        //Compute the sum, or total, of the numbers in the list.
        float totalSum = numbs.Sum();
        
        Console.WriteLine($"The total od the sum is: {totalSum}");

        //Compute the average of the numbers in the list.
        float averg = ((float)totalSum) / numbs.Count;
        Console.WriteLine($"The average of the number in the list is: {averg}");

        //Find the maximum, or largest, number in the list.
        int maxNumb = numbs.Max();
        Console.WriteLine($"The Maximun of the list is: {maxNumb}");

    }
}