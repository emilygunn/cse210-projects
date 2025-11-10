using System.Runtime.CompilerServices;

public class ListingActivity : Activity
{
    //Attributes
    private Random _randInt = new Random();
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private List<string> _responses = new List<string>();

    //Constructor
    public ListingActivity(string name, string description) : base(name, description)
    {
        _name = name;
        _description = description;
        DoStartingMessage();
    }

    //Method
    public void DoActivity()
    {
        int index = _randInt.Next(5);
        GetReady();

        Console.WriteLine("List as many responses as you can to the following prompt:\n");
        Console.WriteLine($" --- {_prompts[index]} ---\n");
        Console.Write("You may begin in: ");
        Countdown(8);
        Console.WriteLine();

        _endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < _endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            _responses.Add(response);
        }
        Console.WriteLine($"You listed {_responses.Count} items!");
        DoEndingMessage();
    }
}