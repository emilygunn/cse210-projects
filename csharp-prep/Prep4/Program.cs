using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();
        int num = -1;
        int sum = 0;
        int max = numbers[0];

        while (num != 0)
        {
            Console.Write("Enter numbers, enter 0 when finished. ");
            num = int.Parse(Console.ReadLine());

            numbers.Add(num);

            sum += num;

            if (num > max)
            {
                max = num;
            }
        }
        int count = numbers.Count;
        float average = (float)sum / count;

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Max: {max}");
    }
}