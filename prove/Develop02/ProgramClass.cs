using System.Security.Cryptography.X509Certificates;

public class ProgramClass
{
    public string response = "0";
    public Journal journal = new Journal();
    public void Menu()
    {

        do
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            response = Console.ReadLine();

            if (response == "1")//Write entry
            {
                journal.StartEntry();
                response = "0";
            }
            else if (response == "2")//Display entries
            {
                journal.DisplayEntries();
                response = "0";
            }
            else if (response == "3")//Load
            {
                journal.LoadFile();
                response = "0";
            }
            else if (response == "4")//Save
            {
                journal.SaveToFile();
                response = "0";
            }
            else if (response == "5")//Quit
            {
                response = "";
            }
            else
            {
                Console.WriteLine("Invalid Respose.");
                response = "0";
            }

        } while ((response == "0"));
    }
}