public class Initiative
{
    //Attributes
    private List<Character> _characters = new List<Character>();
    private int _numOfChar;

    //Constructor
    public Initiative(int numOfCharacters)
    {
        _numOfChar = numOfCharacters;
        //TODO Prompt to add the number of characters to the list
        //"What is the next character (#1) in the list?"
    }

    //Methods
    public List<Character> CreateInit()
    {
        return _characters;
    }
}