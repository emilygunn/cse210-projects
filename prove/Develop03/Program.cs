using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop03 World!");
        string input = "";
        string chosenVerse = "";

        List<string> _scriptures = new List<string>()
        {
            "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the sevice of your fellow beings ye are only in the service of your God.",
            "Adam fell that men might be; and men are, that they might have joy.",
            "Come unto me, all ye that labor and are heavy laden, and I will give you rest. Take my yolk upon you, and learn of me; for I am meek and lowly in heart: and ye shall find rest unto your souls. For my yolk is easy, and my burden is light."
        };

        List<string> _ref1 = new List<string>()
        {
            "Mosiah", "2", "17", ""
        };
        List<string> _ref2 = new List<string>()
        {
            "2 Nephi", "2", "25", ""
        };
        List<string> _ref3 = new List<string>()
        {
            "Matthew", "11", "28", "30"
        };
        
        Console.Write("What scripture would you like to memorize?(1-3) ");
        chosenVerse = Console.ReadLine();

        string text = "";
        string[] words = {""};

        Reference reference = new Reference("Book", "-", "-");

        if (chosenVerse == "1")
        {
            reference.SetReference(_ref1[0], _ref1[1], _ref1[2], _ref1[3]);
            text = _scriptures[0];
            words = text.Split(" ");
        }
        else if (chosenVerse == "2")
        {
            reference.SetReference(_ref2[0], _ref2[1], _ref2[2], _ref2[3]);
            text = _scriptures[1];
            words = text.Split(" ");
        }
        else if (chosenVerse == "3")
        {
            reference.SetReference(_ref3[0], _ref3[1], _ref3[2], _ref3[3]);
            text = _scriptures[2];
            words = text.Split(" ");
        }

        Scripture scripture = new Scripture(words, reference);

        do
        {
            scripture.DisplayScripture();

            Console.Write("\nPress enter to hide more words or type 'quit' to exit. ");
            input = Console.ReadLine();

            scripture.HideWords();
        }
        while (input != "quit" && !scripture.AllWordsHidden());
        scripture.DisplayScripture();
    }
}