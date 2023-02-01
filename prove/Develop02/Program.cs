using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop02 World!");
        Entry runMenu = new Entry();
        runMenu.DisplayMenu();
        
    }
}
/*Erros I found
When in my entry I wrote a comma,
when I want to save, it will split with the comma I wrote so 
I cannot use commas in my entries
what can I do to fix?
change the seperator to other like this "|"
for example 
 */