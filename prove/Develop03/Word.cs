public class Word
{
    //Attributres
    private string _word;
    private bool _hidden;

    //Constructiors
    public Word(string word)
    {
        _word = word;
    }

    //Method
    public void Hide()
    {
        _hidden = true;
    }
    public void UnHide()
    {
        _hidden = false;
    }
    public string Display()
    {
        if (_hidden)
        {
            string hiddenWord = "";
            foreach (char letter in _word)
            {
                hiddenWord += "_";
            }
            return hiddenWord;
        }
        return _word;
    }
    public bool IsHidden()
    {
        if (_hidden)
        {
            return true;
        }
        return false;
    }
}