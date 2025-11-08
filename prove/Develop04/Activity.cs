using System.Diagnostics;

public class Activity
{
    //Attributes
    protected string _name;
    protected string _description;
    protected int _duration;

    //Constructor
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    //Methods
    public void DoStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine(_description);
        Console.Write($"How long, in seconds, would you like for your session?");
        int.TryParse(Console.ReadLine(), out int duration);
        _duration = duration;
    }
    public void DoEndingMessage()
    {
        Console.WriteLine($"\nWell Done!\n");
        Thread.Sleep(1000);
        Console.WriteLine($"You completed another {_duration} of the {_name} Activity.");
        _SpinnerAnimation(_duration);
    }
    private void _SpinnerAnimation(int duration)
    {
        List<string> spinChar = new List<string>(){"-", "/", "|", "\""}; //! Change to use help in assignment
        for (int i = duration; i < 0; i--)
        {
            foreach (string a in spinChar)
            {
                Console.Write(a);
            }
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }
    private void _Countdown(int countFrom)
    {
        for (int i = 5; i < 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }
}