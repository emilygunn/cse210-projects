using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning04 World!");

        Assignment assignment = new Assignment("Billy", "Art");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment math = new MathAssignment("Bob", "Geometry", "1.2", "1-5");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        WritingAssignment writing = new WritingAssignment("Joe", "Poetry", "As Leaves Fall");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetwritingInformation());
    }
}