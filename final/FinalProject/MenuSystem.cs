public class MenuSystem
{
    //Attributes
    private bool _isRunning = true;
    private string _response;
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
    private Interface _interface;
    private bool _showAllRolls = false;
    private bool _showNPCs = true;

    //Constructor
    public MenuSystem()
    {
        Console.WriteLine("Welcome to The D&D Interface!");
        do
        {
            DisplayMenu();
        }
        while (_isRunning == true);
    }

    //Methods
    private void ToggleShowAllRolls()
    {
        if (_showAllRolls)
        {
            _showAllRolls = false;
        }
        else
        {
            _showAllRolls = true;
        }
    }
    private void ToggleShowNPCs()
    {
        if (_showNPCs)
        {
            _showNPCs = false;
        }
        else
        {
            _showNPCs = true;
        }
    }
    public void DisplayMenu()
    {
        Console.WriteLine("\n---Main Menu---");
        Console.WriteLine("1. Create\n2. Update\n3. Roll Dice\n4. Display Interface\n5. Edit Display\n6. Quit");
        Console.Write("\nWhat would you like to do? ");//Enter number
        _response = Console.ReadLine();

        switch (_response)
        {
            case "1"://Create
                Console.WriteLine("\n--Creation Menu--");
                Console.WriteLine("1. Create Player\n2. Create NPC\n3. Create Condition\n4. Create Counter\n5. Create Encounter\n6. Create Game Time\n7. Create Note");
                Console.Write("\nWhat would you like to do? ");//Enter number
                _response = Console.ReadLine();

                switch (_response)
                {
                    case "1"://Player
                        bool pDown;
                        bool pDead;

                        Console.Write("\nWhat is the player's name? ");
                        string pName = Console.ReadLine();

                        Console.Write("\nWhat is the player's race? ");
                        string pRace = Console.ReadLine();

                        Console.Write("\nWhat is the player's class? ");
                        string pClass = Console.ReadLine();

                        Console.Write("\nWhat is the player's current HP? ");
                        int.TryParse(Console.ReadLine(), out int pCurrentHP);

                        Console.Write("\nWhat is the player's max HP? ");
                        int.TryParse(Console.ReadLine(), out int pMaxHP);

                        Console.Write("\nWhat is the player's AC? ");
                        int.TryParse(Console.ReadLine(), out int pAC);

                        Console.Write("\nIs the player down, dead, or alive? ");
                        _response = Console.ReadLine().ToLower();
                        if (_response == "down")
                        {
                            pDown = true;
                            pDead = false;
                        }
                        else if (_response == "dead")
                        {
                            pDown = false;
                            pDead = true;
                        }
                        else
                        {
                            pDown = false;
                            pDead = false;
                        }

                        _characters.Add(new Player(pName, pRace, pClass, pCurrentHP, pMaxHP, pAC, pDown, pDead));
                        _players.Add(new Player(pName, pRace, pClass, pCurrentHP, pMaxHP, pAC, pDown, pDead));
                        break;
                    case "2"://NPC
                        Console.Write("\nDoes this NPC have all of its information (y or n) ");
                        _response = Console.ReadLine().ToLower();
                        if (_response == "y")//Asks for all info (full constructor)
                        {
                            bool npcDown;
                            bool npcDead;

                            Console.Write("\nWhat is the NPC's name? ");
                            string nName = Console.ReadLine();

                            Console.Write("\nWhat is the NPC's race? ");
                            string nRace = Console.ReadLine();

                            Console.Write("\nWhat is the NPC's class? ");
                            string nClass = Console.ReadLine();

                            Console.Write("\nWhat is the NPC's current HP? ");
                            int.TryParse(Console.ReadLine(), out int npcCurrentHP);

                            Console.Write("\nWhat is the NPC's max HP? ");
                            int.TryParse(Console.ReadLine(), out int npcMaxHP);

                            Console.Write("\nWhat is the NPC's AC? ");
                            int.TryParse(Console.ReadLine(), out int npcAC);

                            Console.Write("\nIs the NPC down, dead, or alive? ");
                            _response = Console.ReadLine().ToLower();
                            if (_response == "down")
                            {
                                npcDown = true;
                                npcDead = false;
                            }
                            else if (_response == "dead")
                            {
                                npcDown = false;
                                npcDead = true;
                            }
                            else
                            {
                                npcDown = false;
                                npcDead = false;
                            }

                            _characters.Add(new Npc(nName, nRace, nClass, npcCurrentHP, npcMaxHP, npcAC, npcDown, npcDead));
                            _npcs.Add(new Npc(nName, nRace, nClass, npcCurrentHP, npcMaxHP, npcAC, npcDown, npcDead));
                        }
                        else //Asks for simple info (short constructor)
                        {
                            bool npcDown;
                            bool npcDead;

                            Console.Write("\nWhat is the NPC's name? ");
                            string nName = Console.ReadLine();

                            Console.Write("\nWhat is the NPC's race? ");
                            string nRace = Console.ReadLine();

                            Console.Write("\nIs the NPC down, dead, or alive? ");
                            _response = Console.ReadLine().ToLower();
                            if (_response == "down")
                            {
                                npcDown = true;
                                npcDead = false;
                            }
                            else if (_response == "dead")
                            {
                                npcDown = false;
                                npcDead = true;
                            }
                            else
                            {
                                npcDown = false;
                                npcDead = false;
                            }

                            _characters.Add(new Npc(nName, nRace, npcDown, npcDead));
                            _npcs.Add(new Npc(nName, nRace, npcDown, npcDead));
                        }

                        break;
                    case "3"://Condition
                        Console.Write("\nWhat is the name of the character with the condition? ");
                        string nameOfAfflicted = Console.ReadLine().Trim();
                        
                        //Updates hasContition for character
                        foreach (Character c in _characters)
                        {
                            string checkName = c.GetName();
                            if (checkName.Contains(nameOfAfflicted))
                            {
                                c.ToggleHasCondition();
                            }
                        }

                        Console.Write("\nWhat condition would you like to add? ");
                        _response = Console.ReadLine().Trim().ToLower();
                        switch (_response)
                        {
                            case "blinded":
                                _conditions.Add(new ConditionTracker(nameOfAfflicted, "Blinded"));
                                break;
                            case "charmed":
                                _conditions.Add(new ConditionTracker(nameOfAfflicted, "Charmed"));
                                break;
                            case "deafened":
                                _conditions.Add(new ConditionTracker(nameOfAfflicted, "Deafened"));
                                break;
                            case "frightened":
                                _conditions.Add(new ConditionTracker(nameOfAfflicted, "Frightened"));
                                break;
                            case "grappled":
                                _conditions.Add(new ConditionTracker(nameOfAfflicted, "Grappled"));
                                break;
                            case "incapacitated":
                                _conditions.Add(new ConditionTracker(nameOfAfflicted, "Incapacitated"));
                                break;
                            case "invisible":
                                _conditions.Add(new ConditionTracker(nameOfAfflicted, "Invisible"));
                                break;
                            case "paralyzed":
                                _conditions.Add(new ConditionTracker(nameOfAfflicted, "Paralyzed"));
                                break;
                            case "petrified":
                                _conditions.Add(new ConditionTracker(nameOfAfflicted, "Petrified"));
                                break;
                            case "poisoned":
                                _conditions.Add(new ConditionTracker(nameOfAfflicted, "Poisoned"));
                                break;
                            case "prone":
                                _conditions.Add(new ConditionTracker(nameOfAfflicted, "Prone"));
                                break;
                            case "restrained":
                                _conditions.Add(new ConditionTracker(nameOfAfflicted, "Restrained"));
                                break;
                            case "stunned":
                                _conditions.Add(new ConditionTracker(nameOfAfflicted, "Stunned"));
                                break;
                            case "unconscious":
                                _conditions.Add(new ConditionTracker(nameOfAfflicted, "Unconscious"));
                                break;
                            case "exhaustion":
                                _conditions.Add(new ConditionTracker(nameOfAfflicted, "Exhaustion"));
                                break;
                        }
                        break;
                    case "4"://Counter
                        bool countUp;

                        Console.Write("\nWhat is the name of the counter (what is it for)? ");
                        string countName = Console.ReadLine();

                        Console.Write("\nDoes the counter count up (y or n)? ");
                        _response = Console.ReadLine().ToLower();
                        if (_response == "y")
                        {
                            countUp = true;
                        }
                        else
                        {
                            countUp = false;
                        }

                        Console.Write("\nWhat does the counter start at? ");
                        int.TryParse(Console.ReadLine(), out int countFrom);

                        _counters.Add(new Counter(countName, countUp, countFrom));
                        break;
                    case "5"://Encounter
                        bool diffTerrain;
                        Console.Write("\nHow many characters (including npcs/monsters) are in combat? ");
                        int.TryParse(Console.ReadLine(), out int numOfChar);

                        Console.Write("\nIs there difficult terrain (y or n)? ");
                        _response = Console.ReadLine().ToLower();
                        if (_response == "y")
                        {
                            diffTerrain = true;
                        }
                        else
                        {
                            diffTerrain = false;
                        }

                        Console.Write("\nWhat is the location of the encounter? ");
                        string location = Console.ReadLine();

                        _encounter = new Encounter(numOfChar, diffTerrain, location);
                        break;
                    case "6"://GameTime
                        Console.Write("\nWhat is the current hour? ");
                        int.TryParse(Console.ReadLine(), out int hour);

                        Console.Write("\nWhat is the current minute? ");
                        int.TryParse(Console.ReadLine(), out int minute);

                        Console.Write("\nWhat is the current season? ");
                        string season = Console.ReadLine();
                        _gameTime = new GameTime(hour, minute, season);
                        break;
                    case "7"://Note
                        _notes.Add(new NotePad());
                        break;
                }
                break;
            case "2"://Update
                Console.WriteLine("\n--Update Menu--");
                Console.WriteLine("1. Edit Player\n2. Edit NPC\n3. Remove Condition\n4. Edit Counter\n5. Edit Encounter (Increment Round)\n6. Edit Game Time\n7. Edit Note");
                Console.Write("\nWhat would you like to do? ");//Enter number
                _response = Console.ReadLine();

                switch (_response)
                {
                    case "1"://Player
                        Console.WriteLine("\nPlayers:");
                        int pCount = 1;
                        foreach (Player p in _players)
                        {
                            Console.WriteLine($"{pCount}. {p.DisplayCharacter()}");
                            ++pCount;
                        }
                        Console.Write("\nWhich player would you like to edit? ");
                        int.TryParse(Console.ReadLine(), out int pIndex);
                        pIndex -= 1;

                        _players[pIndex].UpdateInfo();
                        break;
                    case "2"://NPC
                        Console.WriteLine("\nNPCs:");
                        int npcCount = 1;
                        foreach (Npc npc in _npcs)
                        {
                            Console.WriteLine($"{npcCount}. {npc.DisplayCharacter()}");
                            ++npcCount;
                        }
                        Console.Write("\nWhich NPC would you like to edit? ");
                        int.TryParse(Console.ReadLine(), out int npcIndex);
                        npcIndex -= 1;

                        _npcs[npcIndex].UpdateInfo();
                        break;
                    case "3"://Condition
                        Console.WriteLine("\nConditions:");
                        int conCount = 1;
                        foreach (ConditionTracker con in _conditions)
                        {
                            Console.WriteLine($"{conCount}. {con.DisplayCondition()}");
                            ++conCount;
                        }
                        Console.Write("\nWhich condition would you like to remove? ");
                        int.TryParse(Console.ReadLine(), out int conIndex);
                        conIndex -= 1;

                        _conditions[conIndex].ToggleActiveCondition();
                        break;
                    case "4"://Counter
                        Console.WriteLine("\nCounters:");
                        int counterCount = 1;
                        foreach (Counter c in _counters)
                        {
                            Console.WriteLine($"{counterCount}. {c.DisplayCounter()}");
                            ++counterCount;
                        }
                        Console.Write("\nWhich encounter would you like to edit? ");
                        int.TryParse(Console.ReadLine(), out int countIndex);
                        countIndex -= 1;

                        _counters[countIndex].IncrementCounter();
                        break;
                    case "5"://Encounter
                        _encounter.IncrementRound();
                        break;
                    case "6"://GameTime
                        _gameTime.UpdateTime();
                        break;
                    case "7"://Note
                        Console.WriteLine("\nNotes:");
                        int noteCount = 1;
                        foreach (NotePad n in _notes)
                        {
                            Console.WriteLine($"{noteCount}. {n.DisplayNote()}");
                            ++noteCount;
                        }
                        Console.Write("\nWhich note would you like to edit? ");
                        int.TryParse(Console.ReadLine(), out int nIndex);
                        nIndex -= 1;

                        _notes[nIndex].EditNote();
                        break;
                }
                break;
            case "3"://Roll Dice
                Console.WriteLine("\n--Dice Menu--");
                Console.WriteLine("1. Roll Advantage\n2. Roll Disadvantage\n3. Flat Roll\n4. Modified Roll");
                Console.Write("\nWhat would you like to do? ");//Enter number
                _response = Console.ReadLine();

                switch (_response)
                {
                    case "1"://Advantage
                        _allDiceRolls.Add(new DiceRoller("adv"));
                        _lastDiceRoll = _allDiceRolls[_allDiceRolls.Count() - 1];
                        break;
                    case "2"://Disadvantage
                        _allDiceRolls.Add(new DiceRoller("dis"));
                        _lastDiceRoll = _allDiceRolls[_allDiceRolls.Count() - 1];
                        break;
                    case "3"://Flat Roll
                        Console.Write("\nHow many dice would you like to roll? ");
                        int.TryParse(Console.ReadLine(), out int num);
                        int numOfDice = num;
                        Console.Write("\nWhat type of dice would you like to roll? ");
                        int.TryParse(Console.ReadLine(), out int dice);
                        int diceType = dice;

                        _allDiceRolls.Add(new DiceRoller(numOfDice, diceType));
                        _lastDiceRoll = _allDiceRolls[_allDiceRolls.Count() - 1];
                        break;
                    case "4"://Modified Roll
                        Console.Write("\nHow many dice would you like to roll? ");
                        int.TryParse(Console.ReadLine(), out int num2);
                        int numOfDice2 = num2;
                        Console.Write("\nWhat type of dice would you like to roll? ");
                        int.TryParse(Console.ReadLine(), out int dice2);
                        int diceType2 = dice2;
                        Console.Write("\nWhat would you like to add to the roll?");
                        int.TryParse(Console.ReadLine(), out int mod);
                        int toAdd = mod;

                        _allDiceRolls.Add(new DiceRoller(numOfDice2, diceType2, toAdd));
                        _lastDiceRoll = _allDiceRolls[_allDiceRolls.Count() - 1];
                        break;
                }

                // Re-Display Interface
                _interface = new Interface(_encounter, _characters, _players, _npcs, _conditions, _counters, _gameTime, _lastDiceRoll, _allDiceRolls, _notes, _showAllRolls, _showNPCs);
                _interface.DisplayInterface();
                break;
            case "4"://Display interface
                _interface = new Interface(_encounter, _characters, _players, _npcs, _conditions, _counters, _gameTime, _lastDiceRoll, _allDiceRolls, _notes, _showAllRolls, _showNPCs);
                _interface.DisplayInterface();
                break;
            case "5"://Edit Display
                // Toggle rolls and Npcs
                Console.WriteLine("\n--Display Menu--");
                Console.WriteLine("1. Toggle Showing All Rolls\n2. Toggle Showing All NPCs");
                Console.Write("\nWhat would you like to do? ");//Enter number
                _response = Console.ReadLine();

                switch (_response)
                {
                    case "1"://Toggle Rolls
                        ToggleShowAllRolls();
                        break;
                    case "2"://Toggle Npcs
                        ToggleShowNPCs();
                        break;
                }
                break;
            case "6"://Quit
                _isRunning = false;
                break;
        }
    }
}