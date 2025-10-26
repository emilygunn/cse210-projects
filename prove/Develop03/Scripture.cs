public class Scripture
{
    //Attributes
    private List<Word> _words;
    private Reference _reference;

    //Constructors
    public Scripture(string text, Reference reference)
    {

        _reference = reference;
    }

    //Methods
    public void DisplayScripture()
    {
        
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
        
        return true;
        // foreach (Word word in _words)
        // {
        //     if (word.IsHidden())
        //     {
        //         return true;
        //     }
        //     else
        //     {
        //         return false;
        //     }
        // }
    }
}