using System.Data;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop05 World!");

        bool isRunning = true;
        List<Goal> goals = new List<Goal>();
        string description;
        string name;
        int pointValue;
        int bonusPoints;
        int points = 0;
        int level = 0;
        int target;
        int nextLevel = 100;

    do 
    {
        //Leveling
        if (points >= nextLevel)
            {
                level++;
                nextLevel += 100;
                Console.WriteLine($"\nYou are now level {level}!");
            }
        Console.WriteLine($"\nLevel {level}: You have {points} points.\n");

        //Display Menu
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");
        Console.Write("Select a choice from the menu: ");
        string response = Console.ReadLine();
        Console.WriteLine();

        switch(response)
            {
                case "1": //New Goal
                    Console.WriteLine("The types of goals are:");
                    Console.WriteLine("  1. Simple Goal - Completed once.");
                    Console.WriteLine("  2. Eternal Goal - Never ends, counts times completed. Daily Goals.");
                    Console.WriteLine("  3. Checklist Goal - Must be done a given amount of times to be completed.");
                    Console.Write("Which type of goal would you like to create? ");
                    string goalType = Console.ReadLine();

                        switch(goalType)
                        {
                            case "1": //Simple Goal
                                Console.Write("What is the name of your goal? ");
                                name = Console.ReadLine();
                                Console.Write("What is a short description of it? ");
                                description = Console.ReadLine();
                                Console.Write("What is the amount of points associated with it? ");
                                int.TryParse(Console.ReadLine(), out int value1);
                                pointValue = value1;

                                goals.Add(new SimpleGoal(name, description, pointValue));
                                break;
                            case "2": //Eternal Goal
                                Console.Write("What is the name of your goal? ");
                                name = Console.ReadLine();
                                Console.Write("What is a short description of it? ");
                                description = Console.ReadLine();
                                Console.Write("What is the amount of points associated with it? ");
                                int.TryParse(Console.ReadLine(), out int value2);
                                pointValue = value2;

                                goals.Add(new EternalGoal(name, description, pointValue));
                                break;
                            case "3": //Checklist Goal
                                Console.Write("What is the name of your goal? ");
                                name = Console.ReadLine();
                                Console.Write("What is a short description of it? ");
                                description = Console.ReadLine();
                                Console.Write("What is the base amount of points associated with it? ");
                                int.TryParse(Console.ReadLine(), out int value3);
                                pointValue = value3;
                                Console.Write("How many times does this goal need to be comleted for a bonus? ");
                                int.TryParse(Console.ReadLine(), out int targetAmount);
                                target = targetAmount;
                                Console.Write("What is the bonus for completing it that many times? ");
                                int.TryParse(Console.ReadLine(), out int bonusvalue);
                                bonusPoints = bonusvalue;

                                goals.Add(new ChecklistGoal(name, description, pointValue, target, bonusPoints));
                                break;
                        }
                    break;
                case "2": //List Goals
                    int listNumber = 1;
                    Console.WriteLine("The goals are:");
                    foreach(Goal goal in goals)
                    {
                        Console.Write($"{listNumber}. ");
                        Console.WriteLine(goal.DisplayGoal());
                        listNumber++;
                    }
                    break;
                case "3": //Save Goals
                    Console.Write("What is the filename for the goal file? ");
                    string filename = Console.ReadLine();

                    using (StreamWriter outputFile = new StreamWriter(filename))
                    {
                        outputFile.WriteLine($"{level}|{points}");
                        foreach (Goal goal in goals)
                        {
                            outputFile.WriteLine(goal.GetStringRepresentation());
                        }
                    }
                    break;
                case "4": //Load Goals
                
                    Console.Write("What is the filename for the goal file? ");
                    string file = Console.ReadLine();
                    string[] lines = System.IO.File.ReadAllLines(file);

                    string[] parts1 = lines[0].Split("|");
                    int.TryParse(parts1[0], out int l);
                    level = l;
                    int.TryParse(parts1[1], out int tp);
                    points = tp;

                    List<string> linesList = new List<string>(lines);
                    linesList.RemoveAt(0);
                    lines = linesList.ToArray();

                    //Format = goalType:_name|_description|_pointValue|_totalPoints|_isComplete|_currentAmount or _timesCompleted|_targetAmount|_bonusPoints
                    foreach (string line in lines)
                        {
                            string[] parts2 = line.Split(":");

                            goalType = parts2[0];
                            string info = parts2[1];

                            string[] infoParts = info.Split("|");

                            name = infoParts[0];
                            description = infoParts[1];
                            int.TryParse(infoParts[2], out int p);
                            pointValue = p;
                            bool.TryParse(infoParts[3], out bool c);
                            bool isComplete = c;
                            
                            if(goalType == "SimpleGoal")
                            {
                                goals.Add(new SimpleGoal(name, description, pointValue, isComplete));
                            }
                            else if (goalType == "EternalGoal")
                            {
                                int.TryParse(infoParts[4], out int tc);
                                int timesCompleted = tc;

                                goals.Add(new EternalGoal(name, description, pointValue, isComplete, timesCompleted));
                            }
                            else if (goalType == "ChecklistGoal")
                            {
                                int.TryParse(infoParts[4], out int tc);
                                int timesCompleted = tc;
                                int.TryParse(infoParts[5], out int t);
                                target = t;
                                int.TryParse(infoParts[6], out int b);
                                int bonus = b;

                                goals.Add(new ChecklistGoal(name, description, pointValue, isComplete, timesCompleted, target, bonus));
                            }
                        }
                    break;
                case "5": //Record Event (Complete Goal)
                    int listNumber2 = 1;
                    Console.WriteLine("The goals are:");
                    foreach(Goal goal in goals)
                    {
                        Console.Write($"{listNumber2}. ");
                        Console.WriteLine(goal.DisplayGoal());
                        listNumber2++;
                    }
                    Console.Write("Which goal did you accomplish? ");
                    int.TryParse(Console.ReadLine(), out int toAccomplish);
                    int accompIndex = toAccomplish - 1;

                    goals[accompIndex].CompleteGoal();
                    Console.WriteLine($"Congradulations! You have earned {goals[accompIndex].GetPointValue()} points!");

                    points += goals[accompIndex].GetPointValue();

                    Console.WriteLine($"You now have {points} points.");
                    break;
                case "6": //Quit
                    isRunning = false;
                    break;
            }
    }
    while (isRunning);
    }
}