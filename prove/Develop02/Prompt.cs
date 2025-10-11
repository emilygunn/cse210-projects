public class Prompt
{
    public static Random _random = new Random();
    public int _index { get; set; }

    //List of Prompts
    public List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };
    //Returns random prompt 
    public string RandomPrompt()
    {
        _index = _random.Next(5);
        return _prompts[_index];
    }
}