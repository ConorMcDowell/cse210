using System;
using System.Runtime.InteropServices;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    private int _totalPoints;
    List<string[]> goals = new List<string[]>();
    private Program()
    {
        _totalPoints = 0;
    }
    private Program(int points)
    {
        _totalPoints = points;
    }

    static void Main(string[] args)
    {
        Program program = new Program();
        bool i = true;
        while (i == true)
        {
            Console.WriteLine($"Your points: {program._totalPoints}");
            Console.WriteLine("Options: ");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Your choice: ");
            string choice = Console.ReadLine();
            int choice1 = int.Parse(choice);

            if (choice1 == 1)
            {
                program.Create();
            }
            else if (choice1 == 2)
            {
                program.List();
            }
            else if (choice1 == 3)
            {
                program.Save();
            }
            else if (choice1 == 4)
            {
                program.Load();
            }
            else if (choice1 == 5)
            {
                program.Record();
            }
            else if (choice1 == 6)
            {
                i = false;
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Please enter a valid choice");
            }
        }
    }

    public void Create()
    {
        Console.WriteLine("Types of Goal: ");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");
        Console.WriteLine("4. Academic");
        Console.Write("What kind of goal would you like to do? ");
        string type = Console.ReadLine();
        int type1 = int.Parse(type);

        if (type1 == 1)
        {
            SimpleGoal simple1 = new SimpleGoal();
            goals.Add(simple1.Display());
        }
        else if (type1 == 2)
        {
            EternalGoal eternal1 = new EternalGoal();
            goals.Add(eternal1.Display());
        }
        else if (type1 == 3)
        {
            ChecklistGoal checklist1 = new ChecklistGoal();
            goals.Add(checklist1.Display());
        }
        else if (type1 == 4)
        {
            AcademicGoal academic1 = new AcademicGoal();
            goals.Add(academic1.Display());
        }
        else 
        {
            Console.WriteLine("Please enter a valid option");
            Create();
        }
    }

    public void List()
    {
        int i = 1;
        foreach(string[] item in goals)
        {
            Console.Write($"{i}. ");
            foreach(string thing in item)
            {
                Console.Write($"{thing}, ");
            }
            Console.WriteLine();
            i++;
        }
    }

    public void Save()
    {
        Console.Write("What would you like to name your file? ");
        string filename = Console.ReadLine();
        
        using (StreamWriter newfile = new StreamWriter(filename))
        {
            foreach(string[] item in goals)
            {
                foreach(string thing in item)
                {
                    newfile.Write($"{thing}, ");
                }
                newfile.WriteLine();
            }
        }
    }

    public void Load()
    {
        Console.Write("What is the file you would like to load? ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            goals.Add(line.Split(","));
        }
        List();
    }

    public void Record()
    {
        List();
        Console.Write("Which goal did you accomplish? ");
        int done = int.Parse(Console.ReadLine());

        string[] complete = goals[done-1];
        int points = int.Parse(complete[3]);
        
        if (complete[0] == "Simple")
        {
            SimpleGoal simple1 = new SimpleGoal();
            complete[4] = simple1.SetDone(complete[4]);
            for (int i = 0; i < complete.Length; i++)
            {
                Console.Write($"{complete[i]}");
            }
        }
        else if (complete[0] == "Academic")
        {
            SimpleGoal simple1 = new SimpleGoal();
            complete[4] = simple1.SetDone(complete[4]);
            for (int i = 0; i < complete.Length; i++)
            {
                Console.Write($"{complete[i]}");
            }
        }
        else if (complete[0] == "Checklist")
        {
            int completion = int.Parse(complete[4]);
            completion += 1;
            complete[4] = $"{completion}";

            if (int.Parse(complete[4]) == int.Parse(complete[5]))
            {
                _totalPoints += int.Parse(complete[6]);
            }
        }
        
        goals[done-1] = complete;


        _totalPoints += points;
    }
}