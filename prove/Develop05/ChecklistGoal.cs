class ChecklistGoal : Goal
{
    private int _repeat;
    private int _bonus;
    public ChecklistGoal()
    {
        _repeat = 0;
        _bonus = 0;
    }
    public ChecklistGoal(int repeat, int bonus)
    {
        _repeat = repeat;
        _bonus = bonus;
    }

    public override string[] Display()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a brief description of your goal? ");
        string description = Console.ReadLine();

        Console.Write("How many points will you earn for this goal? ");
        string points1 = Console.ReadLine();

        Console.Write("How many times do you need to accomplish this goal for a bonus? ");
        string repeat = Console.ReadLine();

        Console.Write("What is the bonus for accomplishing this goal that many times? ");
        string bonus = Console.ReadLine();

        string finish = "0";

        string[] info = ["Checklist", name, description, points1, finish, repeat, bonus];
        return info;
    }
}