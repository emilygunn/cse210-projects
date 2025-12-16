using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello FinalProject World!");

        //TESTING

        // //Testing character display and editing character info
        //TODO fix Conditions
        // Character test = new Character("Gavea", "Goliath", "Paladin", 82, 88, 18, false, false, false);
        // Console.WriteLine(test.DisplayCharacter());
        // test.UpdateInfo();
        // Console.WriteLine(test.DisplayCharacter());

        // //Testing condition display
        //TODO fix
        // ConditionTracker testCon = new ConditionTracker("Gavea", "Prone");
        // Console.WriteLine(testCon.DisplayCondition());

        // //Testing counter display and increment
        // Counter test1 = new Counter("Test Counter1", true, 0);
        // Console.WriteLine(test1.DisplayCounter());
        // test1.IncrementCounter();
        // Console.WriteLine(test1.DisplayCounter());

        // Counter test2 = new Counter("Test Counter2", false, 10);
        // Console.WriteLine(test2.DisplayCounter());
        // test2.IncrementCounter();
        // Console.WriteLine(test2.DisplayCounter());

        // //Test DiceRoller
        // // adv
        // DiceRoller adv = new DiceRoller("adv");
        // //dis
        // DiceRoller dis = new DiceRoller("dis");
        // //flat
        // DiceRoller flat = new DiceRoller(2, 6);
        // //modifier
        // DiceRoller mod = new DiceRoller(3, 6, 5);

        // //Test Encounter
        // Encounter testEnc = new Encounter(3, false, "Crystal Valley");
        // Console.WriteLine(testEnc.DisplayEncounter());
        // testEnc.IncrementRound();
        // Console.WriteLine(testEnc.DisplayEncounter());

        // Encounter testEnc2 = new Encounter(3, true, "Deep Cavern");
        // Console.WriteLine(testEnc2.DisplayEncounter());

        // //Test GameTime
        // GameTime testTime = new GameTime(5, 02, "Winter");
        // Console.WriteLine(testTime.DisplayGameTime());
        // testTime.UpdateTime();
        // Console.WriteLine(testTime.DisplayGameTime());

        // // Test Initiative
        // Initiative testInit = new Initiative(3);
        // Console.WriteLine(testInit.DisplayInit());

        // //Test NotePad
        // NotePad testNote = new NotePad();
        // Console.WriteLine(testNote.DisplayNote());

        // testNote.EditNote();
        // Console.WriteLine(testNote.DisplayNote());

        //Test NPC and Player
        // //Player
        // Player testPlayer = new Player("Feral", "Tiefling", "Rouge", 10, 25, 16, false, false, true);
        // Console.WriteLine(testPlayer.DisplayCharacter());
        //NPC
        Npc testNpc = new Npc("Whisper", "Shifter", false, false, false);
        Console.WriteLine(testNpc.DisplayCharacter());
        Npc testNpc2 = new Npc("Whisper", "Shifter", "Fighter", 36, 36, 12, false, true, false);
        Console.WriteLine(testNpc2.DisplayCharacter());

        //Test MenuSystem

        //Interface

        //Program
    }
}