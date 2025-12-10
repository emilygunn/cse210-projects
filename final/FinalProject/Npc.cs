public class Npc : Character
{
    //Attributes
    private bool _isHidden;

    //Constructors
    public Npc(string name, string race, string clas, int currentHP, int maxHP, int ac, bool isDown, bool isDead, bool hasCondition) :base (name, race, clas, currentHP, maxHP, ac, isDown, isDead, hasCondition)
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
    public Npc(string name, string race, bool isDown, bool isDead, bool hasCondition) : base (name, race, isDown, isDead, hasCondition)
    {
        _name = name;
        _race = race;
        _isDown = isDown;
        _isDead = isDead;
        _hasCondition = hasCondition;
    }

    //Methods
    public bool ToggleIsHidden()
    {
        return _isHidden;
        //TODO finish toggle
    }
    public bool GetVisibility()
    {
        return _isHidden;
    }
    public override string DisplayCharacter()
    {
        //TODO if full consructor then display base.DisplayCharacter
        return base.DisplayCharacter();
        //TODO if short constructor then override
    }
}