using System.Runtime.InteropServices;

public class SimpleGoal : Goal
{
    //Constructors
    public SimpleGoal(string name, string description, int pointValue) : base (name, description, pointValue)
    {
        
    }
    public SimpleGoal(string name, string description, int pointValue, bool completed) : base (name, description, pointValue, completed)
    {
        
    }

    //Methods
    public override string DisplayGoal()
    {
        if (_isComplete)
        {
            return $"[X] {_name }: {_description}";
        }
        else
        {
            return $"[ ] {_name }: {_description}";
        }
    }
    public override void CompleteGoal()
    {
        if (!_isComplete)
        {
            _isComplete = true;
        }
        else
        {
            Console.WriteLine("This goal is already completed.");
        }
    }
    public override int GetPointValue()
    {
        return _pointValue;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_name}|{_description}|{_pointValue}|{_isComplete}";
    }
}