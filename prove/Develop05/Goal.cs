public abstract class Goal
{
    //Attributes
    protected string _name;
    protected string _description;
    protected int _pointValue;
    protected int _pointTotal;
    protected bool _isComplete = false;

    //Constructor
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _pointValue = points;
    }
    public Goal(string name, string description, int points, bool completed)
    {
        _name = name;
        _description = description;
        _pointValue = points;
        _isComplete = completed;
    }

    //Methods
    public abstract string DisplayGoal();
    public abstract void CompleteGoal();
    public abstract int GetPointValue();
    public abstract string GetStringRepresentation();
}