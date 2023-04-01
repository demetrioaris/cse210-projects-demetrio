using System;

class Program
{
    static void Main(string[] args)
    {
        // Create 3 Event and Set the Address
        // Event 01
        var e01 = new Event("Computer Conference", "This is a description of my event.", "2023-05-15", "10:00 PM", "Lectures");
        e01.SetAddress(new List<Address>()
        {
            new Address("Grand Hotel","456 East St", "Anytown", "CA", "USA")
        });
        e01.SetLectures(new List<Lectures>()
        {
            new Lectures("jonh", 50)
        });

        // Event 02
        var e02 = new Event("The great Event", "This is a description of my event.", "2023-06-15", "9:00 PM", "Receptions");
        e02.SetAddress(new List<Address>()
        {
            new Address("Plaza Great","123 Main St", "Anytown", "NY", "USA")
        });
        e02.SetReceptions(new List<Receptions>()
        {
            new Receptions("www.register.com")
        });

        // Event 03
        var e03 = new Event("Concert in the outside", "This is a description of my event.", "2023-07-15", "10:00 AM", "Outdoor");
        e03.SetAddress(new List<Address>()
        {
            new Address("Plaza Great","8910 Central St", "Anytown", "PTY", "Panamá")
        });
        e03.SetOutdoor(new List<Outdoor>()
        {
            new Outdoor("Sunny")
        });

        // Display the 3 types of messagge
        // Standard 
        Console.WriteLine(e01.GetStandardMsg());
        Console.WriteLine(e02.GetStandardMsg());
        Console.WriteLine(e03.GetStandardMsg());

        // Full 
        Console.WriteLine(e01.GetFullMsg());
        Console.WriteLine(e02.GetFullMsg());
        Console.WriteLine(e03.GetFullMsg());

        // Short
        Console.WriteLine(e01.GetShortMsg());
        Console.WriteLine(e02.GetShortMsg());
        Console.WriteLine(e03.GetShortMsg());

    }
}