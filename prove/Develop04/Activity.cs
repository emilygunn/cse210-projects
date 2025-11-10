using System.Diagnostics;

public class Activity
{
    //Attributes
    protected string _name;
    protected string _description;
    protected int _duration;
    protected DateTime _startTime = DateTime.Now;
    protected DateTime _endTime;

    //Constructor
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    //Methods
    public void DoStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine($"{_description}\n");
        Console.Write($"How long, in seconds, would you like for your session? ");
        int.TryParse(Console.ReadLine(), out int duration);
        _duration = duration;
    }
    public void DoEndingMessage()
    {
        Console.WriteLine($"\nWell Done!");
        SpinnerAnimation(8);
        Console.WriteLine($"You completed another {_duration} seconds of the {_name} Activity.");
        SpinnerAnimation(8);
        Console.Clear();
    }
    protected void SpinnerAnimation(int duration)
    {
        Console.CursorVisible = false;
        List<string> spinChar = new List<string>() { "-", "\\", "|", "/" };
        int index = 0;
        for (int i = duration; i > 0; i--)
        {
            string s = spinChar[index];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            index++;

            if (index >= spinChar.Count)
            {
                index = 0;
            }
        }
        Console.CursorVisible = true;
    }
    protected void Countdown(int countFrom)
    {
        Console.CursorVisible = false;
        for (int i = countFrom; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.CursorVisible = true;
    }
    protected void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        SpinnerAnimation(8);
        Console.WriteLine("\n");
    }
}