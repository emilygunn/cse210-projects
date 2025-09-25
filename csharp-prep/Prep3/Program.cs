using System;
using System.IO.Pipes;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");

        // Console.Write("What is the magic number? ");
        // int magicNum = int.Parse(Console.ReadLine());
        Random randomGen = new Random();
        int magicNum = randomGen.Next(1, 100);
        int guess = 0;

        do
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());


            if (guess < magicNum)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNum)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Correct");
            }
        } while (guess != magicNum);
    }
}