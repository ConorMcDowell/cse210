using System;

class Program
{
    static void Main(string[] args)
    {
        bool i = true;
        while (i == true)
        {
            Console.WriteLine("Exercises: ");
            Console.WriteLine("1. Running");
            Console.WriteLine("2. Cycling");
            Console.WriteLine("3. Swimming");
            Console.WriteLine("4. Quit");
            Console.Write("Your choice: ");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("When did you complete this exercise? ");
            string date = Console.ReadLine();
            Console.Write("How long in minutes did it take you to finish? ");
            float length = float.Parse(Console.ReadLine());

            string type;

            switch(choice) 
            {
            case 1:
                type = "Running";
                Console.Write("How long in km did you run? ");
                float distance = float.Parse(Console.ReadLine());
                Running running1 = new Running(distance, date, length);
                Console.WriteLine($"{running1.GetSummary(type, distance, running1.CalcSpeed(), running1.CalcPace(distance))}");
                break;
            case 2:
                type = "Cycling";
                Console.Write("What was your average speed in km/h? ");
                float speed = float.Parse(Console.ReadLine());
                Cycling cycling1 = new Cycling(speed, date, length);
                Console.WriteLine($"{cycling1.GetSummary(type, cycling1.CalcDistance(), speed, cycling1.CalcPace(cycling1.CalcDistance()))}");
                break;
            case 3:
                type = "Swimming";
                Console.Write("How many laps did you swim? ");
                int laps = int.Parse(Console.ReadLine());
                Swimming swimming1 = new Swimming(laps, date, length);
                Console.WriteLine($"{swimming1.GetSummary(type, swimming1.CalcDistance(), swimming1.CalcSpeed(), swimming1.CalcPace(swimming1.CalcDistance()))}");
                break;
            case 4:
                i = false;
                Console.WriteLine("Goodbye!");
                break;
            default:
                break;
            }
        }


    }
}