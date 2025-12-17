public class Interface
{
    //Attributes
    private Encounter _encounter;
    private List<Character> _characters = new List<Character>();
    private List<Player> _players = new List<Player>();
    private List<Npc> _npcs = new List<Npc>();
    private List<ConditionTracker> _conditions = new List<ConditionTracker>();
    private List<Counter> _counters = new List<Counter>();
    private GameTime _gameTime;
    private DiceRoller _lastDiceRoll;
    private List<DiceRoller> _allDiceRolls = new List<DiceRoller>();
    private List<NotePad> _notes = new List<NotePad>();
    private bool _showAllRolls;
    private bool _showNPCs;

    //Constructor
    public Interface(Encounter encounter, List<Character> characters, List<Player> players, List<Npc> npcs, List<ConditionTracker> conditions, List<Counter> counters, GameTime gameTime, DiceRoller lastDiceRoll, List<DiceRoller> allRolls, List<NotePad> notes, bool showRolls, bool showNPCs)
    {
        _encounter = encounter;
        _characters = characters;
        _players = players;
        _npcs = npcs;
        _conditions = conditions;
        _counters = counters;
        _gameTime = gameTime;
        _lastDiceRoll = lastDiceRoll;
        _allDiceRolls = allRolls;
        _notes = notes;
        _showAllRolls = showRolls;
        _showNPCs = showNPCs;
    }

    //Methods
    public void DisplayInterface()
    {
        Console.WriteLine("\n- - - = = = | D&D Interface | = = = - - -");

        //GameTime
        Console.WriteLine("\n~Game Time~");
        if (_gameTime != null)
        {
            Console.WriteLine(_gameTime.DisplayGameTime());
        }
        else
        {
            Console.WriteLine("---");
        }

        //Counters
        Console.WriteLine("\n~Session Counters~");
        if (_counters.Count() != 0)
        {
            foreach(Counter counter in _counters)
        {
            Console.WriteLine(counter.DisplayCounter());
        }
        }
        else
        {
            Console.WriteLine("---");
        }

        //Notes
        Console.WriteLine("\n~Session Notes~");
        if (_notes.Count() != 0)
        {
            foreach (NotePad note in _notes)
            {
                Console.WriteLine(note.DisplayNote());
            }
        }
        else
        {
            Console.WriteLine("---");
        }

        //Characters (check NPC toggle)
        Console.WriteLine("\n~Players~");
        if (_characters.Count() != 0)
        {
            if (_showNPCs)
            {
                foreach (Player p in _players)
                {
                    Console.WriteLine(p.DisplayCharacter());
                }
                Console.WriteLine("\n~NPCs~");
                if (_npcs.Count() != 0)
                {
                    foreach (Npc n in _npcs)
                    {
                        Console.WriteLine(n.DisplayCharacter());
                    }
                }
                else
                {
                    Console.WriteLine("---");
                }
            }
            else
            {
                foreach (Player p in _characters)
                {
                    Console.WriteLine(p.DisplayCharacter());
                }
            }
        }
        else
        {
            Console.WriteLine("---");
        }

        //Conditions
        Console.WriteLine("\n~Active Conditions~");
        if (_conditions.Count() != 0)
        {
            foreach (ConditionTracker c in _conditions)
            {
                Console.WriteLine(c.DisplayCondition());
            }
        }
        else
        {
            Console.WriteLine("---");
        }

        //Encounter
        Console.WriteLine("\n~Encounter~");
        if (_encounter != null)
        {
            Console.WriteLine(_encounter.DisplayEncounter());
        }
        else
        {
            Console.WriteLine("---");
        }

        //Dice (Check roll toggle)
        if (_allDiceRolls.Count() != 0 || _lastDiceRoll != null)
        {
            if (_showAllRolls)
            {
                Console.WriteLine("\n~All Rolls~");
                foreach (DiceRoller roll in _allDiceRolls)
                {
                    Console.Write($"{roll}  ");
                }
            }
            else
            {
                Console.WriteLine($"\n~Last Roll~ {_lastDiceRoll}");
            }
        }
        else
        {
            Console.WriteLine("\n~Rolls~\n---");
        }

        Console.WriteLine("\n       - - - = = = --- = = = - - -");
    }
}