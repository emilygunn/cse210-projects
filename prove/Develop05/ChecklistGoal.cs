public class ChecklistGoal : Goal
{
    //Attributes
    private int _bonusPoints;
    private int _targetAmount;
    private int _currentAmount = 0;

    //Constructors
    public ChecklistGoal(string name, string description, int pointValue, int target, int bonus) : base (name, description, pointValue)
    {
        _targetAmount = target;
        _bonusPoints = bonus;
    }
    public ChecklistGoal(string name, string description, int pointValue, bool completed, int timesCompleted, int target, int bonus) : base (name, description, pointValue, completed)
    {
        _currentAmount = timesCompleted;
        _targetAmount = target;
        _bonusPoints = bonus;
    }

     //Methods
    public override string DisplayGoal()
    {
        return $"[{_currentAmount}/{_targetAmount}] {_name }: {_description}";
    }
    public override void CompleteGoal()
    {
        _currentAmount++;
        if (_currentAmount == _targetAmount)
        {
            _isComplete = true;
        }
        else
        {
            _isComplete = false;
        }
    }
    public override int GetPointValue()
    {
        if (_isComplete)
        {
            return _bonusPoints;
        }
        return _pointValue;
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_name}|{_description}|{_pointValue}|{_isComplete}|{_currentAmount}|{_targetAmount}|{_bonusPoints}";
    }
}