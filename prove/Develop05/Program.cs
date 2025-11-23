using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop05 World!");
        //TODO Add leveling, new nevel every 100 points

        bool isRunning = true;
        List<Goal> goals = new List<Goal>();

    do 
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");
        Console.Write("Select a choice from the menu: ");

        string response = Console.ReadLine();

        switch(response)
            {
                case "1":
                    Console.WriteLine("The types of goals are:");
                    
                    // goals.Add();
                break;
                case "2":
                    foreach(Goal goal in goals)
                    {
                        
                    }
                break;
                case "3":
                break;
                case "4":
                break;
                case "5":
                break;
                case "6":
                isRunning = false;
                break;
            }
    }
    while (isRunning);
    }
}