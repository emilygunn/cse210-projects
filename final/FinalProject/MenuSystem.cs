public class MenuSystem
{
    //Attributes
    private bool _isRunning = true;
    private string _response;
    private List<Encounter> _encounters;
    private List<Character> _characters;
    private List<Player> _players;
    private List<Npc> _npcs;
    private List<ConditionTracker> _conditions;
    private List<Counter> _counters;
    private string _gameTime;
    private string _lastDiceRoll;
    private List<DiceRoller> _allDiceRolls;
    private List<NotePad> _notes;

    //Constructor
    public MenuSystem()
    {
        Console.WriteLine("Welcome to The D&D Interface!\n");
        do
        {
            DisplayMenu();
        }
        while (_isRunning == true);
    }

    //Methods
    public void DisplayMenu()
    {
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Create\n2. Update\n3. Roll Dice\n4. Display Interface");
        Console.Write("What would you like to do? ");//Enter number
        _response = Console.ReadLine();

        switch (_response)
        {
            case "1"://Create
                //Player
                //NPC
                //Condition
                //Counter
                //Encounter
                //GameTime
                //Note
                break;
            case "2"://Update
                //Player
                //NPC
                //Condition
                //Counter
                //Encounter
                //GameTime
                //Note

                //Re-Display Interface
                break;
            case "3"://Roll Dice

                //Re-Display Interface
                break;
            case "4"://Display interface
                break;
            case "5"://Edit Display
                //Toggle rolls and Npcs
                break;
        }
    }
    //TODO
    //Creates list of ConditionTracker to give to Interface (GetConditions Method - Take from Character/ConditionTracker classes
    //if nameOfAfflicted is in _characters, ToggleHasCondition

    //Checks visibility for NPCs, if visible then display
}