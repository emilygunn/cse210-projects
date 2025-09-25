using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        //Class 9/25/25
        //functions
        int x = 2;
        int y = 3;
        int sum = Adder(x, y);
        Console.WriteLine(sum);

        string name = "Jill";
        GreetUser(name);

        Console.WriteLine($"x before: {x}");
        ChangeValue(x);
        Console.WriteLine($"AAfter: {x}");

        int[] myArray = new int[] { 1, 2, 3, 4, 5, };
        Console.Write("Before: ");
        foreach (int number in myArray)
        {
            Console.Write($"{number} ");
        }

        ChangeReference(myArray);
        Console.WriteLine("After: ");

        Console.Write("Before: ");
        foreach (int number in myArray)
        {
            Console.Write($"{number} ");
        }

    }
    static int Adder(int a, int b) //static = standalone function not associated with a specific class
    {
        return a + b;
    }

    static void ChangeValue(int x)
    {
        x = 100;
    }

    static void ChangeReference(int[] data)
    {
        data[2] = 100;
    }

    static void GreetUser(string firstName) // static = doesn't return anything
    {
        Console.WriteLine($"Hello {firstName}!");
    }

}