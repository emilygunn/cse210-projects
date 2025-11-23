public class SimpleGoal : Goal
{
    //Constructor
    public SimpleGoal(string name, string description, int pointValue) : base (name, description, pointValue)
    {
        
    }

    //Methods
    public override void DisplayGoal()
    {
        
    }
    public override void CompleteGoal()
    {
        _isComplete = true;
    }
    public override void CalculatePoints()
    {
        if (_isComplete)
        {
            _pointTotal += _pointValue;
        }
    }
}