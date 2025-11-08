public class BreathingActivity : Activity
{
    //Constructor
    public BreathingActivity(string name, string description, string duration) : base(name, description)
    {
        _name = name;
        _description = description;
        int.TryParse(duration, out int d);
        _duration = d;
        
        DoStartingMessage();
    }
    
    //Method
    public void DoActivity()
    {
        
    }
}