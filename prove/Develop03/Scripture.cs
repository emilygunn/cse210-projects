public class Scripture
{
    //Attributes
    private List<Word> _words = new List<Word>();
    private Reference _reference;
    private Random _randInt = new Random();
    private bool _isTrue = true;

    //Constructors
    public Scripture(string[] text, Reference reference)
    {
        foreach (string word in text)
        {
            Word w = new Word(word);
            _words.Add(w);
        }
        _reference = reference;
    }

    //Methods
    public void DisplayScripture()
    {
        Console.Clear();
        Console.WriteLine(_reference.GetReference());
        foreach (Word word in _words)
        {
            Console.Write($"{word.Display()} ");
        }
    }
    public void HideWords()
    {
        int index = _randInt.Next(_words.Count);
        _words[index].Hide();
    }
    public bool AllWordsHidden()
    {
        if (_words.Any(word => !word.IsHidden()))
        {
            return false;
        }
        return true;
    }
}