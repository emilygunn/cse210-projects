public class Encounter
{
    //Attributes
    Initiative _init;
    private Counter _roundCount = new Counter("Round", true, 0);//Name of Counter = "Round:", _doesCountUp = true, _countFrom = 0
    private bool _isDifficultTerrain;
    private string _location;
    private int _numOfCharacters;

    //Constructor
    public Encounter(int numOfCharacters, bool isDifficultTerrain, string location)
    {
        _numOfCharacters = numOfCharacters;
        _isDifficultTerrain = isDifficultTerrain;
        _location = location;
        _init = new Initiative(_numOfCharacters);
    }

    //Methods
    public void IncrementRound()
    {
        _roundCount.IncrementCounter();
    }
    public string DisplayEncounter()
    {
        return $"{_roundCount.DisplayCounter()} - {_location} - Has Difficult Terrain: {_isDifficultTerrain}\nInitiative:\n{_init.DisplayInit()}";
    }
}