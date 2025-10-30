public class Reference
{
    //Attributes
    private string _book;
    private string _chatper;
    private string _startVerse;
    private string _endVerse;

    //Constructors
    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chatper = chapter;
        _startVerse = verse;
    }
    public Reference(string book, string chapter, string startVerse, string endVerse)
    {
        _book = book;
        _chatper = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    //Methods
    public string GetReference()
    {
        if (string.IsNullOrWhiteSpace(_endVerse))
        {
            return $"{_book} {_chatper}:{_startVerse}";
        }
        return $"{_book} {_chatper}:{_startVerse}-{_endVerse}";
    }
    
    public void SetReference(string book, string chapter, string startVerse, string endVerse)
    {
        _book = book;
        _chatper = chapter;
        _startVerse = startVerse;
        if (endVerse != "")
        {
            _endVerse = endVerse;
        }
    }
}