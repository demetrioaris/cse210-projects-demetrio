using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning05 World!");
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("red", 4);
        shapes.Add(s1);

        Rectangle r1 = new Rectangle("blue", 6, 4);
        shapes.Add(r1);

        Circle c1 = new Circle("green", 4);
        shapes.Add(c1);
        

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"Color: {color} --> Area: {area}");
        }
    }
}