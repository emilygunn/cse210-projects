using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning05 World!");

        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("red", 2);
        // Console.WriteLine(s1.GetColor());
        // Console.WriteLine(s1.GetArea());
        shapes.Add(s1);

        Rectangle r1 = new Rectangle("orange", 2, 4);
        // Console.WriteLine(r1.GetColor());
        // Console.WriteLine(r1.GetArea());
        shapes.Add(r1);

        Circle c1 = new Circle("yellow", 2);
        // Console.WriteLine(c1.GetColor());
        // Console.WriteLine(c1.GetArea());
        shapes.Add(c1);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}