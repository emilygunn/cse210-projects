using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep5 World!");

        DisplayWelcome();

        string name = PromptUserName();
        int num = PromptUserNumber();
        int squNum = SquareNumber(num);

        int year;
        PromptUserBirthYear(out year);

        DisplayResult(name, squNum, year);
    }
    
    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Enter your favorite number: ");
            int num = int.Parse(Console.ReadLine());

            return num;
        }

        static void PromptUserBirthYear(out int year)
        {
            Console.Write("Enter birth year: ");
            year = int.Parse(Console.ReadLine());
        }

        static int SquareNumber(int num)
        {
            int numSqu = num * num;
            return numSqu;
        }

        static void DisplayResult(string name, int sqNum, int birth)
        {
            int age = 2025 - birth;

            Console.WriteLine($"{name}, the square of your number is {sqNum}");
            Console.WriteLine($"{name}, you will turn {age} this year.");
        }
}