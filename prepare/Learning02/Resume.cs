public class Resume
{
    //attributes
    public string _name;
    public List<Job> _jobs = new List<Job>();

    //methods
    public void DisplayResumeDetails()
    {
        Console.WriteLine($"Name: {_name}");

        Console.WriteLine("Jobs:");
        foreach (Job j in _jobs)
        {
            j.DisplayJobDetails();
        }
    }
}