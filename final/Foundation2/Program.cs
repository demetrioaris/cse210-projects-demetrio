using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation2 World!");
        // create customers
        var john = new Custumer("John");
        var alice = new Custumer("Alice");

        // add addresses for customers
        john.SetAddress(new List<Address>()
        {
            new Address("123 Main St", "Anytown", "CA", "USA"),
        });
        alice.SetAddress(new List<Address>()
        {
            new Address("789 Elm St", "Tocumen", "Panamá", "PTY")
        });

        // create products
        var iphone = new Product("iPhone", "1234", 999.99m, 2);
        var ipad = new Product("iPad", "5678", 799.99m, 1);
        var macbook = new Product("MacBook Pro", "9012", 1999.99m, 1);
        var applewatch = new Product("Apple Watch", "3456", 399.99m, 3);

        // create orders with customers and products
        var order1 = new Order(new List<Custumer>() { john }, new List<Product>() { iphone, ipad });
        var order2 = new Order(new List<Custumer>() { alice }, new List<Product>() { macbook, applewatch, iphone });

        // call methods to get packing label, shipping label, and total price for each order
        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine();
        order1.TotalPrice();
        
        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine();
        order2.TotalPrice();
    }
}