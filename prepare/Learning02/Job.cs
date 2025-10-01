public class Job
{
    //attributes
    public string _company;
    public string _jobTitle;
    public string _startYear;
    public string _endYear;

    //methods
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}