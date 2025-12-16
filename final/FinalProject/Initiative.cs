public class Initiative
{
    //Only used by Encounter

    //Attributes
    private List<string> _characters = new List<string>();
    private int _numOfChar;

    //Constructor
    public Initiative(int numOfCharacters)
    {
        _numOfChar = numOfCharacters;
        
        for (int i = 1; i <= _numOfChar; ++i)
        {
            Console.Write($"What is the next character (#{i}) in the list? ");
            _characters.Add(Console.ReadLine());
        }
    }

    //Methods
    public string DisplayInit()
    {
        int index = 1;
        string showInit = "";
        foreach (string c in _characters)
        {
            showInit += $"{index}. {c}\n";
            index++;
        }
        return showInit;
    }
}