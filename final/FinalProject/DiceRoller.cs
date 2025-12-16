public class DiceRoller
{
    //Attributes
    private Random _randInt = new Random();
    private int _numOfDice;
    private int _diceType;
    private int _toAdd;
    private int _roll1 { get; set; }
    private int _roll2 { get; set; }
    private string _choice;

    //Constructors
    //For Advantage or Disadvantage roll
    public DiceRoller(string choice)
    {
        _choice = choice.Trim().ToLower();
        if (_choice == "adv")
        {
            RollAdv();
        }
        else if (_choice == "dis")
        {
            RollDis();
        }
        else
        {
            Console.WriteLine("Invalid Input. Enter 'adv' or 'dis'.");
        }
    }
    //Flat roll (no modifier)
    public DiceRoller(int numOfDice, int diceType)
    {
        _numOfDice = numOfDice;
        _diceType = diceType;
        RollFlat();
    }
    //Modified roll (adds to roll)
    public DiceRoller(int numOfDice, int diceType, int toAdd)
    {
        _numOfDice = numOfDice;
        _diceType = diceType;
        _toAdd = toAdd;
        RollWithAdd();
    }

    //Methods
    private void RollAdv()
    {
        _roll1 = _randInt.Next(21);
        _roll2 = _randInt.Next(21);
        List<int> _rolls = new List<int>(){_roll1, _roll2};
        
        Console.WriteLine($"Adv({_roll1},{_roll2}): {_rolls.Max()}");
    }
    private void RollDis()
    {
        _roll1 = _randInt.Next(21);
        _roll2 = _randInt.Next(21);
        List<int> _rolls = new List<int>(){_roll1, _roll2};
        
        Console.WriteLine($"Dis({_roll1},{_roll2}): {_rolls.Min()}");
    }
    private void RollFlat()//Used numOfDice and diceType
    {
        string rollResults = "";
        int rollTotal = 0;
        for (int i = 0; i < _numOfDice; i++)
        {
            _roll1 = _randInt.Next(_diceType + 1);
            rollTotal += _roll1;
            if (i >= _numOfDice - 1)
            {
                rollResults += $"{_roll1}";
            }
            else
            {
                rollResults += $"{_roll1} + ";
            }
        }
        Console.WriteLine($"Flat Roll({_numOfDice}d{_diceType}): {rollResults} = {rollTotal}");
    }
    private void RollWithAdd()//Uses numOfDice, diceType, and toAdd
    {
        string rollResults = "";
        int rollTotal = 0;
        for (int i = 0; i < _numOfDice; i++)
        {
            _roll1 = _randInt.Next(_diceType + 1);
            rollTotal += _roll1;
            if (i >= _numOfDice - 1)
            {
                rollResults += $"{_roll1}";
            }
            else
            {
                rollResults += $"{_roll1} + ";
            }
        }
        rollTotal += _toAdd;
        Console.WriteLine($"Roll({_numOfDice}d{_diceType} + {_toAdd}): {rollResults} + {_toAdd} = {rollTotal}");
    }
}