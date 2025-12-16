public class NotePad
{
    //Attributes
    private string _noteContents;

    //Constructor
    public NotePad()
    {
        Console.Write("What is the note?\n> ");
        string contents = Console.ReadLine();
        _noteContents = $"> {contents}";
    }

    //Methods
    //Re-writes note
    public void EditNote()
    {
        Console.Write("What is the new note?\n> ");
        string contents = Console.ReadLine();
        _noteContents = $"> {contents}";
    }
    public string DisplayNote()
    {
        return _noteContents;
    }
}