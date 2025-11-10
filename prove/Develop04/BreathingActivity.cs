public class BreathingActivity : Activity
{
    //Constructor
    public BreathingActivity(string name, string description) : base(name, description)
    {
        _name = name;
        _description = description;
        DoStartingMessage();
    }

    //Methods
    public void DoActivity()
    {
        GetReady();

        _endTime = _startTime.AddSeconds(_duration);
        while (DateTime.Now < _endTime)
        {
            Console.Write("Breathe in... ");
            Countdown(4);
            Console.WriteLine("\n");
            Console.Write("Breathe out... ");
            Countdown(6);
            Console.WriteLine("\n");
        }
        DoEndingMessage();
    }
}