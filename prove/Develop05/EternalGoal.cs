public class EternalGoal : Goal
{
    //Attributes
    private int _timesCompleted = 0;

    //Constructors
    public EternalGoal(string name, string description, int pointValue) : base (name, description, pointValue)
    {
        
    }
    public EternalGoal(string name, string description, int pointValue, bool completed, int timesCompleted) : base (name, description, pointValue, completed)
    {
        _timesCompleted = timesCompleted;
    }

     //Methods
    public override string DisplayGoal()
    {
        if (_isComplete)
        {
            return $"[{_timesCompleted}] {_name }: {_description}";
        }
        else
        {
            return $"[ ] {_name }: {_description}";
        }
    }
    public override void CompleteGoal()
    {
        _isComplete = true;
        _timesCompleted++;
    }
    public override int GetPointValue()
    {
        return _pointValue;
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_name}|{_description}|{_pointValue}|{_isComplete}|{_timesCompleted}";
    }
}