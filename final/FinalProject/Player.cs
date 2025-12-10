public class Player : Character
{
    //Attributes
    //none

    //Constructor
    public Player(string name, string race, string clas, int currentHP, int maxHP, int ac, bool isDown, bool isDead, bool hasCondition) :base (name, race, clas, currentHP, maxHP, ac, isDown, isDead, hasCondition)
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

    //Methods
    //none
}