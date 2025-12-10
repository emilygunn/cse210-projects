public class NotePad
{
    //Attributes
    private string _noteContents;

    //Constructor
    public NotePad(string contents)
    {
        _noteContents = contents;
    }

    //Methods
    public void EditNote(string contents)
    {
        _noteContents = contents;
    }
    public string DisplayNote()
    {
        return "";
    }
}