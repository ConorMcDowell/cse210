//Stretch Challenge
class AcademicGoal : Goal
{
        private bool _done;
    public AcademicGoal()
    {
        _done = false;
    }
    public AcademicGoal(bool done)
    {
        _done = done;
    }

    public override string[] Display()
    {
        Console.WriteLine("What are you making this goal for? ");
        Console.WriteLine("1. Homework (10 points)");
        Console.WriteLine("2. Test (25 points)");
        Console.WriteLine("3. Project (50 points)");
        Console.Write("Your choice: ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("What is a brief description of your goal? ");
        string description = Console.ReadLine();

        string name = " ";
        string points1 = " ";

        if (choice == 1)
        {
            name = "Homework";
            points1 = "10";
        }
        else if (choice == 2)
        {
            name = "Test";
            points1 = "25";
        }
        else if (choice == 3)
        {
            name = "Project";
            points1 = "50";
        }
        string complete = "[ ]";

        string[] info = ["Academic", name, description, points1, complete];
        return info;
    }

    public string SetDone(string info)
    {
        info = "[X]";
        return info;
    }
}