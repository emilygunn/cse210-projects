using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());
        string letter = "None";

        if (grade >= 90)
        {
            letter = "A";
            // Console.WriteLine("You have an A");
        }
        else if (grade >= 80)
        {
            letter = "B";
            // Console.WriteLine("You have a B");
        }
        else if (grade >= 70)
        {
            letter = "C";
            // Console.WriteLine("You have a D");
        }
        else
        {
            letter = "F";
            // Console.WriteLine("You have an F");
        }
        Console.WriteLine($"Your grade: {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congradulations! You have passed the class!");
        }
        else
        {
            Console.WriteLine("You have failed the class. Do better.");
        }
    }
}