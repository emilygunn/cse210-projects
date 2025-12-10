public class Character
{
    //Attributes
    protected string _name;
    protected string _race;
    protected string _class;
    protected int _currentHP;
    protected int _maxHP;
    protected int _ac;
    protected bool _isDown;
    protected bool _isDead;
    protected bool _hasCondition;
    protected List<string> _conditions = new List<string>();

    //Constructors
    public Character(string name, string race, string clas, int currentHP, int maxHP, int ac, bool isDown, bool isDead, bool hasCondition)
    {
        _name = name;
        _race = race;
        _class = clas;
        _currentHP = currentHP;
        _maxHP = maxHP;
        _ac = ac;
        _isDown = isDown;
        _isDead = isDead;
        _hasCondition = hasCondition;
    }
    public Character(string name, string race, bool isDown, bool isDead, bool hasCondition)
    {
        _name = name;
        _race = race;
        _isDown = isDown;
        _isDead = isDead;
        _hasCondition = hasCondition;
    }

    //Methods
    public virtual string DisplayCharacter()
    {
        if(_isDown)
        {
            return $"{_name} - {_race} {_class}\n  HP: {_currentHP}/{_maxHP} | AC: {_ac}\n  Status: Down | HasCondition: {_hasCondition}";
        }
        else if (_isDead)
        {
            return $"{_name} - {_race} {_class}\n  HP: {_currentHP}/{_maxHP} | AC: {_ac}\n  Status: Dead | HasCondition: {_hasCondition}";
        }
        return $"{_name} - {_race} {_class}\n  HP: {_currentHP}/{_maxHP} | AC: {_ac}\n  Status: Alive | HasCondition: {_hasCondition}";
    }
    public List<string> GetConditions()
    {
        return _conditions;
    }
    public void ToggleHasCondition()
    {
        if (_hasCondition)
        {
            _hasCondition = false;
        }
        else
        {
            _hasCondition = true;
        }
    }
    public virtual void UpdateInfo()
    {
        Console.WriteLine("UPDATE CHARACTER INFO:\n");
        Console.WriteLine("1. Name\n2. Race\n3. Class\n4. Current HP\n5. Max HP\n6. Armor Class\n7. Status");

        Console.Write("\nWhat would you like to update? ");
        string response = Console.ReadLine();

        switch (response)
        {
            case "1": //Name
                Console.Write("Enter Updated Name: ");
                _name = Console.ReadLine();
                break;
            case "2": //Race
                Console.Write("Enter Updated Race: ");
                _race = Console.ReadLine();
                break;
            case "3": //Class
                Console.Write("Enter Updated Class: ");
                _class = Console.ReadLine();
                break;
            case "4": //Current HP
                Console.WriteLine("Updating Current HP:");
                Console.Write("+ or - : ");
                string currentHpEdit = Console.ReadLine().Trim();
                Console.WriteLine("Enter how much: ");
                int.TryParse(Console.ReadLine(), out int currentNum);
                int changeBy = currentNum;

                if (currentHpEdit == "+") //Current hit points cannot be greater than max hit points
                {
                    _currentHP += changeBy;
                    if (_currentHP > _maxHP)
                    {
                        _currentHP = _maxHP;
                    }
                }
                else if (currentHpEdit == "-") //If current hit points are reduce to 0 then character is Downed
                {
                    _currentHP -= changeBy;
                    if (_currentHP < 0)
                    {
                        _currentHP = 0;
                        _isDown = true;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
                break;
            case "5": //Max HP
                Console.WriteLine("Enter New Max HP:");
                int.TryParse(Console.ReadLine(), out int newMax);
                _maxHP = newMax;
                break;
            case "6": //AC
                Console.Write("Enter New AC: ");
                int.TryParse(Console.ReadLine(), out int newAC);
                _ac = newAC;
                break;
            case "7": //Status - isDown or isDead
                Console.WriteLine("1. isDown\n2. isDead");
                Console.Write("What would you like to update? ");
                string statusResponse = Console.ReadLine();

                if (statusResponse == "1") //Toggle isDown
                {
                    if (_isDown)
                    {
                        _isDown = false;
                    }
                    else
                    {
                        _isDown = true;
                        _currentHP = 0;
                    }
                }
                else if (statusResponse == "2") //Toggle isDead
                {
                    if (_isDead)
                    {
                        _isDead = false;
                    }
                    else
                    {
                        _isDead = true;
                        _isDown = false;
                        _currentHP = 0;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
                break;
            //  case "8": //Condition //TODO Move to ConditionTracker //TODO Create conditions through ConditionTracker then toggle hasCondition
            //     Console.Write("Would you like to Add or Remove a condition? ");
            //     string conditionRes1 = Console.ReadLine().Trim().ToLower();

            //     if (conditionRes1 == "add")
            //     {
            //         _hasCondition = true;
            //         Console.Write("What condition would you like to add? ");
            //         string conditionRes2 = Console.ReadLine().Trim().ToLower();
            //         switch (conditionRes2)
            //         {
            //             case "blinded":
            //                 _conditions.Add(new ConditionTracker(_name, "Blinded").GetConditionName());
            //                 break;
            //             case "charmed":
            //                 _conditions.Add(new ConditionTracker(_name, "Charmed").GetConditionName());
            //                 break;
            //             case "deafened":
            //                 _conditions.Add(new ConditionTracker(_name, "Deafened").GetConditionName());
            //                 break;
            //             case "frightened":
            //                 _conditions.Add(new ConditionTracker(_name, "Frightened").GetConditionName());
            //                 break;
            //             case "grappled":
            //                 _conditions.Add(new ConditionTracker(_name, "Grappled").GetConditionName());
            //                 break;
            //             case "incapacitated":
            //                 _conditions.Add(new ConditionTracker(_name, "Incapacitated").GetConditionName());
            //                 break;
            //             case "invisible":
            //                 _conditions.Add(new ConditionTracker(_name, "Invisible").GetConditionName());
            //                 break;
            //             case "paralyzed":
            //                 _conditions.Add(new ConditionTracker(_name, "Paralyzed").GetConditionName());
            //                 break;
            //             case "petrified":
            //                 _conditions.Add(new ConditionTracker(_name, "Petrified").GetConditionName());
            //                 break;
            //             case "poisoned":
            //                 _conditions.Add(new ConditionTracker(_name, "Poisoned").GetConditionName());
            //                 break;
            //             case "prone":
            //                 _conditions.Add(new ConditionTracker(_name, "Prone").GetConditionName());
            //                 break;
            //             case "restrained":
            //                 _conditions.Add(new ConditionTracker(_name, "Restrained").GetConditionName());
            //                 break;
            //             case "stunned":
            //                 _conditions.Add(new ConditionTracker(_name, "Stunned").GetConditionName());
            //                 break;
            //             case "unconscious":
            //                 _conditions.Add(new ConditionTracker(_name, "Unconscious").GetConditionName());
            //                 break;
            //             case "exhaustion":
            //                 _conditions.Add(new ConditionTracker(_name, "Exhaustion").GetConditionName());
            //                 break;
            //         }
            //     }
            //     else if (conditionRes1 == "remove")
            //     {
            //         _hasCondition = false;
            //         if (_conditions.Count > 1)
            //         {
            //             int counter = 1;
            //             Console.WriteLine("Conditions:");
            //             foreach (string condition in _conditions)
            //             {
            //                 Console.WriteLine($"{counter}. {condition}");
            //                 ++counter;
            //             }
            //             Console.Write("Which would you like to remove? ");
            //             int.TryParse(Console.ReadLine(), out int removeCon);
            //             int index = removeCon - 1;
            //             string toRemove = _conditions[index];
            //             _conditions.Remove(toRemove);
            //         }
            //         else
            //         {
            //             _conditions.Clear();
            //         }
            //     }
            //     else
            //     {
            //         Console.WriteLine("Invalid Input");
            //     }
            //     break;
        }
    }
}