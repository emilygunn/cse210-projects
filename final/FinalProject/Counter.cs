public class Counter
{
    //Attributes
    private string _counterName;
    private bool _doesCountUp;
    private int _countFrom;
    private int _currentCount;

    //Constructor
    public Counter(string counterName, bool doesCountUp, int countFrom)
    {
        _counterName = counterName;
        _doesCountUp = doesCountUp;
        _currentCount = countFrom;
        _countFrom = countFrom;
    }

    //Methods
    public string DisplayCounter()
    {
        return $"{_counterName}: {_currentCount}";
    }
    public void IncrementCounter()
    {
        if (_doesCountUp)
        {
            _currentCount += 1;
        }
        else
        {
            _currentCount -= 1;
        }
    }
    // public void ResetCounter()
    // {
        //Uses countFrom
    // }
}