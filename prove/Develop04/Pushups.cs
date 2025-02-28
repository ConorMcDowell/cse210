class Pushups : Activity
{
    public void Pushup()
    {
        string name = "Pushups";
        string description = "This activity will make you physically as well as mentally stronger!";

        int seconds = Start(name, description);

        for (int i = 0; i < seconds; i += 3)
        {
            PushupActivity(seconds);
        }

        End(name, seconds);
    }

    public void PushupActivity(int seconds)
    {
        Console.WriteLine("0");
        Console.WriteLine("|");
        Console.Write("|");
        Thread.Sleep(1500);
        Console.Clear();

        Console.Write("_0_");
        Thread.Sleep(1500);
        Console.Write("\b \b");
        Console.Write("\b \b");
        Console.Write("\b \b");
        Console.Write("\b \b");
    }
}