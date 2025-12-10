public class Interface
{
    //Attributes
    private List<Encounter> _encounters;
    private List<Character> _characters;
    private List<Player> _players;
    private List<Npc> _npcs;
    private List<ConditionTracker> _conditions;
    private List<Counter> _counters;
    private string _gameTime;
    private string _lastDiceRoll;
    private List<DiceRoller> _allDiceRolls;
    private bool _showAllRolls;
    private List<NotePad> _notes;

    //Constructor
    public Interface(List<Encounter> encounters, List<Character> characters, List<ConditionTracker> conditions, List<Counter> counters, string gameTime, string lastDiceRoll, List<NotePad> _notes)
    {
        
    }

    //Methods
    public void DisplayInterface()
    {
        
    }
    public void ToggleShowAllRolls()
    {
        
    }
    public void ToggleShowNPCs()
    {
        
    }
}