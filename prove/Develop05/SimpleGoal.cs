using System.ComponentModel.DataAnnotations;

class SimpleGoal : Goal
{
    private bool _done;
    public SimpleGoal()
    {
        _done = false;
    }
    public SimpleGoal(bool done)
    {
        _done = done;
    }

    public override string[] Display()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a brief description of your goal? ");
        string description = Console.ReadLine();

        Console.Write("How many points will you earn for this goal? ");
        string points1 = Console.ReadLine();

        string complete = "[ ]";

        string[] info = ["Simple", name, description, points1, complete];
        return info;
    }

    public string SetDone(string info)
    {
        info = "[X]";
        return info;
    }
}
