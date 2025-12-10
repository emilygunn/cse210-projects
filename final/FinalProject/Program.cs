using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello FinalProject World!");

        //TESTING

        //Testing character display and editing character info
        Character test = new Character("Gavea", "Goliath", "Paladin", 82, 88, 18, false, false, false);
        Console.WriteLine(test.DisplayCharacter());
        test.UpdateInfo();
        Console.WriteLine(test.DisplayCharacter());

        //Testing condition display
        ConditionTracker testCon = new ConditionTracker("Gavea", "Prone");
        Console.WriteLine(testCon.DisplayCondition());

        //Testing counter display and increment
        

        //Program
    }
}