public class Scripture
{
    //Attributes
    private List<Word> _words = new List<Word>();
    private Reference _reference;
    private List<string> _scriptures = new List<string>()
    {
        ""
    };
    private List<string> _references = new List<string>()
    {
        ""
    };

    //Constructors
    public Scripture(string text, Reference reference)
    {
        _words = text.Split(" ");
        _reference = reference;
    }

    //Methods
    public void DisplayScripture()
    {
        Console.Clear();
        Console.WriteLine(_reference);
        foreach (Word word in _words)
        {
            Console.Write(word);
        }
    }
    public void HideWords()
    {
        foreach (Word word in _words)
        {
            word.Hide();
        }
    }
    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            bool isTrue = false;
            if (word.IsHidden())
            {
                isTrue = true;
            }
            else
            {
                isTrue = false;
                return false;
            }
            if (isTrue == true)
            {
                return true;
            }
        }
        return false;
    }
}