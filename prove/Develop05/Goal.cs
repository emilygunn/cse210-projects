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
        name = _name;
        description = _description;
        points = _pointValue;
    }

    //Methods
    public abstract void DisplayGoal();
    public abstract void CompleteGoal();
    public abstract void CalculatePoints();
    public int GetPoints()
    {
        return _pointTotal;
    }
    public virtual void SaveGoals()
    {
        
    }
    public virtual void LoadGoals()
    {
        
    }
}