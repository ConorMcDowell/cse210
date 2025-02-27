using System.Net.Quic;

class Activity
{
    public void Menu()
    {
        bool quit = false;
        while (quit == false)
        {
            Console.WriteLine("Choose one of the following: ");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflecting");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Quit");

            Console.Write("My choice: ");
            string choice = Console.ReadLine();
            int myChoice = int.Parse(choice);

            if (myChoice == 1)
            {
                Breathing breathing1 = new Breathing();
                breathing1.Breath();
            }
            else if (myChoice == 2)
            {
                Reflection reflection1 = new Reflection();
                reflection1.Reflect();
            }
            else if (myChoice == 3)
            {
                Listing listing1 = new Listing();
                listing1.List();
            }
            else if (myChoice == 4)
            {
                quit = true;
                Console.WriteLine("Goodbye!");
                while (true)
                {
                    Animation();
                }
            }
            else 
            {
                Console.WriteLine("Please enter a valid response");
            }
        }
    }

    public int Start(string name, string description)
    {
        Console.WriteLine($"Hello! Welcome to the {name} activity!");
        
        Console.WriteLine($"{description}");
        
        Console.Write("How long would you like to do this activity for? ");
        string time = Console.ReadLine();
        int seconds = int.Parse(time);

        Console.WriteLine("Get ready!");
        Animation();

        return seconds;
    }

    public void Animation()
    {
        Console.Write(">>>");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("\b \b");
        Console.Write("\b \b");
        Console.Write("^^^");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("\b \b");
        Console.Write("\b \b");
        Console.Write("<<<");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("\b \b");
        Console.Write("\b \b");
        Console.Write("^^^");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("\b \b");
        Console.Write("\b \b");
    }

    
    public void Random(List<string> prompts)
    {
        Random random = new Random(); 
        int random1 = random.Next(0, prompts.Count);

        Console.WriteLine($"{prompts[random1]}");
    } 

    public void CountDown(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(seconds - i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("\b \b");
        }
    }

    public void End(string name, int seconds)
    {
        Console.WriteLine("Well done!");
        Animation();
        Console.WriteLine($"You have completed the {name} activity.");
        Console.WriteLine($"It took you {seconds} seconds.");
        Animation();
    }
}