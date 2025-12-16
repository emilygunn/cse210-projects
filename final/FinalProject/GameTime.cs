public class GameTime
{
    //Attributes
    private int _currentHour;
    private int _currentMinute;
    private string _currentTime; //Hour:Minute
    private string _currentSeason;

    //Constructor
    public GameTime(int currentHour, int currentMin, string currentSeason)
    {
        _currentHour = currentHour;
        _currentMinute = currentMin;
        if (_currentMinute < 10)
        {
            _currentTime = $"{_currentHour}:0{_currentMinute}";
        }
        else
        {
            _currentTime = $"{_currentHour}:{_currentMinute}";
        }
        _currentSeason = currentSeason;
    }

    //Methods
    public void UpdateTime()
    {
        //Mimics real time for now
        Console.Write("How many hours would you like to add? ");
        int.TryParse(Console.ReadLine(), out int hours);
        int addHours = hours;
        Console.Write("How many minutes would you like to add? ");
        int.TryParse(Console.ReadLine(), out int min);
        int addMinutes = min;

        for (int i = 1; i <= addMinutes; ++i)
        {
            _currentMinute += 1;
            if (_currentMinute > 59)
            {
                _currentMinute = 0;
            }
        }
        for (int i = 1; i <= addHours; ++i)
        {
            _currentHour += 1;
            if (_currentHour > 23)
            {
                _currentHour = 0;
            }
        }
        if (_currentMinute < 10)
        {
            _currentTime = $"{_currentHour}:0{_currentMinute}";
        }
        else
        {
            _currentTime = $"{_currentHour}:{_currentMinute}";
        }
    }
    public string DisplayGameTime()
    {
        return $"Season: {_currentSeason} | Time: {_currentTime}";
    }
}