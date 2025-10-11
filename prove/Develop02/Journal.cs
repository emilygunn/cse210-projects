using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public string _filename = "";
    public string _separator = "~";
    public string _journalName = "";

    //Create New Entry and add to _entries list
    public void StartEntry()
    {
        Entry entry = new Entry();
        _entries.Add(entry.NewEntry());
    }
    //Display Entries
    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            string e = entry.DisplayEntry();
            Console.WriteLine(e);
        }
    }
    //Saves Journal to new file
    public void SaveToFile()
    {
        Console.Write("What would you like to name your journal? ");
        _journalName = Console.ReadLine();

        Console.Write("What do you want to call the file? ");
        _filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            foreach (Entry entry in _entries)
            {
                string e = entry.DisplayEntry();
                outputFile.WriteLine($"{_journalName}\n{e}{_separator}");
            }
        }
    }
    //Loads saved Journal file
    public void LoadFile()
    {
        Console.Write("What file do you want to load? ");
        _filename = Console.ReadLine();

        string[] entries = System.IO.File.ReadAllLines(_filename);

        foreach (string e in entries)
        {
            string[] parts = e.Split(_separator);
            for (int i = 0; i < parts.Length; i++)
            {
                Console.WriteLine(parts[i]);
            }
        }
    }
}