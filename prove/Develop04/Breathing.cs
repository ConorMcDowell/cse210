using System.Security.Cryptography;

class Breathing : Activity
{
    public void Breath()
    {
        string name = "Breathing";
        string description = "This activity will help you to relax by focusing on your breathing.";
        
        int seconds = Start(name, description);

        BreathingActivity(seconds);

        End(name, seconds); 
    }

    public void BreathingActivity(int seconds)
    {
        for (int i = 0; i < seconds; i += 6)
        {
            Console.WriteLine("Breath in...");
            CountDown(3);
            Console.WriteLine("Breath Out...");
            CountDown(3);
        }
    }
}