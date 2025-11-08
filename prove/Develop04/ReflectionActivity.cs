using System.Linq.Expressions;

public class ReflectionActivity : Activity
{
    //Attributes
    private List<string> _prompts = new List<string>();
    private List<string> _reflectionQuestions = new List<string>();

    //Constructor
    public ReflectionActivity(string name, string duration) : base(name, duration)
    {

    }
    
    //Method
    public void DoActivity()
    {
        
    }
}