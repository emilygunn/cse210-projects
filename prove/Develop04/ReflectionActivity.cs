using System.Linq.Expressions;

public class ReflectionActivity : Activity
{
    //Attributes
    private Random _randInt = new Random();
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };
    private List<string> _reflectionQuestions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    //Constructor
    public ReflectionActivity(string name, string description) : base(name, description)
    {
        _name = name;
        _description = description;
        DoStartingMessage();
    }
    
    //Method
    public void DoActivity()
    {
        int index1 = _randInt.Next(4);
        GetReady();

        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($" --- {_prompts[index1]} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this expirience.");
        Console.Write("You may begin in: ");
        Countdown(5);
        Console.Clear();
        _endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < _endTime)
        {
            int index2 = _randInt.Next(9);
            Console.Write($"> {_reflectionQuestions[index2]} ");
            SpinnerAnimation(15);
            Console.WriteLine();
        }
        DoEndingMessage();
    }
}