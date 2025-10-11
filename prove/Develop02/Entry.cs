using System.Diagnostics;

public class Entry
{
    public string _prompt = new Prompt().RandomPrompt();
    public DateTime _dateTime = DateTime.Now;
    public string _entry = "";
    public string _fullEntry = "";

    //Creates New Entry
    public Entry NewEntry()
    {
        Console.WriteLine(_prompt);
        Console.Write("> ");
        _entry = Console.ReadLine();
        return new Entry { _entry = _entry };
    }
    //Displays entry
    public string DisplayEntry()
    {
        string _date = _dateTime.ToShortDateString();
        string _time = _dateTime.ToShortTimeString();
        _fullEntry = $"{_date} - {_time}\n{_prompt}\n{_entry}";
        return _fullEntry;
    }
}