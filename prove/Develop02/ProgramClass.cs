using System.Security.Cryptography.X509Certificates;

public class ProgramClass
{
    public string _response = "0";
    public Journal _journal = new Journal();
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
            _response = Console.ReadLine();

            if (_response == "1")//Write entry
            {
                _journal.StartEntry();
                _response = "0";
            }
            else if (_response == "2")//Display entries
            {
                _journal.DisplayEntries();
                _response = "0";
            }
            else if (_response == "3")//Load
            {
                _journal.LoadFile();
                _response = "0";
            }
            else if (_response == "4")//Save
            {
                _journal.SaveToFile();
                _response = "0";
            }
            else if (_response == "5")//Quit
            {
                _response = "";
            }
            else
            {
                Console.WriteLine("Invalid Respose.");
                _response = "0";
            }

        } while ((_response == "0"));
    }
}