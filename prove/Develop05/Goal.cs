class Goal
{
    private int _points;
    private string _name;
    private string _description;
    protected Goal()
    {
        _points = 0;
        _name = " ";
        _description = " ";
    }
    protected Goal(int points1, string name1, string description1)
    {
        _points = points1;
        _name = name1;
        _description = description1;
    }

    public virtual string[] Display()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a brief description of your goal? ");
        string description = Console.ReadLine();

        Console.Write("How many points will you earn for this goal? ");
        string points1 = Console.ReadLine();

        string[] info = [name, description, points1];
        return info;
    }
}