public class Encounter
{
    //Attributes
    private List<Character> _init = new List<Character>();
    private Counter _roundCount = new Counter("Round:", true, 0);//Name of Counter = "Round:", _doesCountUp = true, _countFrom = 0
    private bool _isDificultTerrain;
    private string _location;

    //Constructor
    public Encounter()
    {
        
    }

    //Methods
    public void IncrementRound()
    {
        
    }
    public string DisplayEncounter()
    {
        return "";
    }
}