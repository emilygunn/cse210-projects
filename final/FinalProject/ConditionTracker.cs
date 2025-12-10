public class ConditionTracker
{
    //Attributes
    private List<string> _conditions = new List<string>();
    private List<string> _conditionNames = new List<string>()
    {
        "Blinded", "Charmed", "Deafened", "Frightened", "Grappled", "Incapacitated", "Invisible", "Paralyzed", "Pretrified", "Poisoned", "Prone", "Restrained", "Stunned", "Unconscious", "Exhaustion"
    };
    private List<string> _effects = new List<string>()
    {
        "   Can't See: You can't see and automatically fail any ability check that requires sight.\n   Attacks Affected: Attack rolls against you have Advantage, and your attack rolls have Disadvantage.",//Blinded
        "   Can't Harm the Charmer: You can't attack the charmer or target the charmer with damaging abilities or magical effects.\n   Social Advantage: The charmer has Advantage on any ability check to interact with you socially.",//Charmed
        "   Can't Hear: You can't hear and automatically fail any ability check that requires hearing.",//Deafened
        "   Ability Checks and Attacks Affected: You have Disadvantage on ability checks and attack rolls while the source of fear is within line of sight.\n   Can't Approach: You can't willingly move closer to the source of fear.",//Frightened
        "   Speed 0: Your Speed is 0 and can't increase.\n   Attacks Affected: You have Disadvantage on attack rolls against any target other than the grappler.\n   Movable: The grappler can drag or carry you when it moves, but every foot of movement costs it 1 extra foot unless you are Tiny or two or more sizes smaller than it.",//Grappled
        "   Inactive: You can't take any action, Bonus Action, or Reaction.\n   No Concentration: Your Concentration is broken.\n   Speechless: You can't speak.\n   Surprised: If you're Incapacitated when you roll Initiative, you have Disadvantage on the roll.",//Incapacitated
        "   Surprise: If you're Invisible when you roll Initiative, you have Advantage on the roll.\n   Concealed: You aren't affected by any effect that requires its target to be seen unless the effect's creator can somehow see you. Any equipment you are wearing or carrying is also concealed.\n   Attacks Affected: Attack rolls against you have Disadvantage, and your attack rolls have Advantage. If a creature can somehow see you, you don't gain this benefit against that creature.",//Invsible
        "   Incapacitated: You have the Incapacitated condition.\n   Speed 0: Your Speed is 0 and can't increase.\n  Saving Throws Affected: You automatically fail Strength and Dexterity saving throws.\n   Attacks Affected: Attack rolls against you have Advantage.\n   Automatic Critical Hits: Any attack roll that hits you is a Critical Hit if the attacker is within 5 feet of you.",//Paralyzed
        "   Turned to Inanimate Substance: You are transformed, along with any nonmagical objects you are wearing and carrying, into a solid inanimate substance (usually stone). Your weight increases by a factor of ten, and you cease aging.\n   Incapacitated: You have the Incapacitated condition.\n   Speed 0: Your Speed is 0 and can't increase.\n   Attacks Affected: Attack rolls against you have Advantage.\n   Saving Throws Affected: You automatically fail Strength and Dexterity saving throws.\n   Resist Damage: You have Resistance to all damage.\n   Poison Immunity: You have Immunity to the Poisoned condition.",//Petrified
        "   Ability Checks and Attacks Affected: You have Disadvantage on attack rolls and ability checks.",//Poisoned
        "   Restricted Movement: Your only movement options are to crawl or to spend an amount of movement equal to half your Speed (round down) to right yourself and thereby end the condition. If your Speed is 0, you can't right yourself.\n   Attacks Affected: You have Disadvantage on attack rolls. An attack roll against you has Advantage if the attacker is within 5 feet of you. Otherwise, that attack roll has Disadvantage.",//Prone
        "   Speed 0: Your Speed is 0 and can't increase.\n   Attacks Affected: Attack rolls against you have Advantage, and your attack rolls have Disadvantage.\n   Saving Throws Affected: You have Disadvantage on Dexterity saving throws.",//Restrained
        "   Incapacitated: You have the Incapacitated condition.\n   Saving Throws Affected: You automatically fail Strength and Dexterity saving throws.\n   Attacks Affected: Attack rolls against you have Advantage.",//Stunned
        "   Inert: You have the Incapacitated and Prone conditions, and you drop whatever you're holding. When this condition ends, you remain Prone.\n   Speed 0: Your Speed is 0 and can't increase.\n   Attacks Affected: Attack rolls against you have Advantage.\n   Saving Throws Affected: You automatically fail Strength and Dexterity saving throws.\n   Automatic Critical Hits: Any attack roll that hits you is a Critical Hit if the attacker is within 5 feet of you.\n   Unaware: You're unaware of your surroundings.",//Unconscious
        "   Exhaustion Levels: This condition is cumulative. Each time you receive it, you gain 1 Exhaustion level. You die if your Exhaustion level is 6.\n   D20 Tests Affected: When you make a D20 Test, the roll is reduced by 2 times your Exhaustion level.\n   Speed Reduced: Your Speed is reduced by a number of feet equal to 5 times your Exhaustion level.",//Exhaustion
    };
    //Durations of conditions and other influence
    private List<string> _durations = new List<string>()
    {
        "Until specified",//Blinded
        "Until specified or damaged",//Charmed
        "Until specified",//Deafened
        "Until specified",//Frightened
        "Until freed",//Grappled
        "Until specified or helped",//Incapacitated
        "Until specified or fails Consentration",//Invsible
        "Until specified",//Paralyzed
        "Until specified",//Petrified
        "Until specified",//Poisoned
        "Until standing",//Prone
        "Until freed",//Restrained
        "Until specified",//Stunned
        "Until specified or helped",//Unconscious
        "Until all levels of Exhaustion are removed",//Exhaustion
    };
    //How the Character can remove conditions themselves
    private List<string> _toEnd = new List<string>()
    {
        "Removed with Action or Save",//Blinded
        "Removed with Save",//Charmed
        "Removed with Action or Save",//Deafened
        "Removed with Save",//Frightened
        "Removed with Action: Athletics or Acrobatics Check",//Grappled
        "Removed with Save",//Incapacitated
        "Removed when specified",//Invsible
        "Removed with Save",//Paralyzed
        "Removed when specified",//Petrified
        "Removed with Save or Spell",//Poisoned
        "Spend movement equal to half of Speed (rounded down)",//Prone
        "Removed with Action: Athletics or Acrobatics Check",//Restrained
        "Removed with Save",//Stunned
        "Removed when specified",//Unconscious
        "Removing Exhaustion Levels: Finishing a Long Rest removes 1 of your Exhaustion levels. When your Exhaustion level reaches 0, the condition ends.",//Exhaustion
    };

    private int _currentCondition;
    private string _nameOfAfflicted;

    //Constructor
    public ConditionTracker(string nameOfAfflicted, string nameOfCondition)
    {
        _nameOfAfflicted = nameOfAfflicted;
        if (_conditionNames.Contains(nameOfCondition))
        {
            _currentCondition = _conditionNames.IndexOf(nameOfCondition);
        }
    }

    //Methods
    public string DisplayCondition()
    {
        return $"::{_nameOfAfflicted}:: - {_conditionNames[_currentCondition]}\nEffects:\n{_effects[_currentCondition]}\nDuration: {_durations[_currentCondition]}, {_toEnd[_currentCondition]}\n";
    }
    public string GetConditionName()
    {
        return $"{_conditionNames[_currentCondition]}";
    }
    // public void CreateCondition()
    // {
    //     Console.Write("What is the name of the character with the condition? ");
    //     _nameOfAfflicted = Console.ReadLine().Trim();

    //     Console.Write("What condition would you like to add? ");
    //     string conditionRes2 = Console.ReadLine().Trim().ToLower();
    //     switch (conditionRes2)
    //     {
    //         case "blinded":
    //             _conditions.Add(new ConditionTracker(_nameOfAfflicted, "Blinded").GetConditionName());
    //             break;
    //         case "charmed":
    //             _conditions.Add(new ConditionTracker(_nameOfAfflicted, "Charmed").GetConditionName());
    //             break;
    //         case "deafened":
    //             _conditions.Add(new ConditionTracker(_nameOfAfflicted, "Deafened").GetConditionName());
    //             break;
    //         case "frightened":
    //             _conditions.Add(new ConditionTracker(_nameOfAfflicted, "Frightened").GetConditionName());
    //             break;
    //         case "grappled":
    //             _conditions.Add(new ConditionTracker(_nameOfAfflicted, "Grappled").GetConditionName());
    //             break;
    //         case "incapacitated":
    //             _conditions.Add(new ConditionTracker(_nameOfAfflicted, "Incapacitated").GetConditionName());
    //             break;
    //         case "invisible":
    //             _conditions.Add(new ConditionTracker(_nameOfAfflicted, "Invisible").GetConditionName());
    //             break;
    //         case "paralyzed":
    //             _conditions.Add(new ConditionTracker(_nameOfAfflicted, "Paralyzed").GetConditionName());
    //             break;
    //         case "petrified":
    //             _conditions.Add(new ConditionTracker(_nameOfAfflicted, "Petrified").GetConditionName());
    //             break;
    //         case "poisoned":
    //             _conditions.Add(new ConditionTracker(_nameOfAfflicted, "Poisoned").GetConditionName());
    //             break;
    //         case "prone":
    //             _conditions.Add(new ConditionTracker(_nameOfAfflicted, "Prone").GetConditionName());
    //             break;
    //         case "restrained":
    //             _conditions.Add(new ConditionTracker(_nameOfAfflicted, "Restrained").GetConditionName());
    //             break;
    //         case "stunned":
    //             _conditions.Add(new ConditionTracker(_nameOfAfflicted, "Stunned").GetConditionName());
    //             break;
    //         case "unconscious":
    //             _conditions.Add(new ConditionTracker(_nameOfAfflicted, "Unconscious").GetConditionName());
    //             break;
    //         case "exhaustion":
    //             _conditions.Add(new ConditionTracker(_nameOfAfflicted, "Exhaustion").GetConditionName());
    //             break;
    //     }
    // }
    // public void RemoveCondition()
    // {
    //     if (_conditions.Count > 1)
    //     {
    //         int counter = 1;
    //         Console.WriteLine("Conditions:");
    //         foreach (string condition in _conditions)
    //         {
    //             Console.WriteLine($"{counter}. {condition}");
    //             ++counter;
    //         }
    //         Console.Write("Which would you like to remove? ");
    //         int.TryParse(Console.ReadLine(), out int removeCon);
    //         int index = removeCon - 1;
    //         string toRemove = _conditions[index];
    //         _conditions.Remove(toRemove);
    //     }
    //     else
    //     {
    //         _conditions.Clear();
    //     }
    // }
}