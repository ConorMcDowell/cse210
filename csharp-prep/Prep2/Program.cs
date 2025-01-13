using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int percent = int.Parse(grade);

        string letter = "";
        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent < 90 && percent >= 80)
        {
            letter = "B";
        }
        else if (percent < 80 && percent >= 70)
        {
            letter = "C";
        }
        else if (percent < 70 && percent >= 60)
        {
            letter = "D";
        }
        else if (percent < 60)
        {
            letter = "F";
        }

        string sign = "";
        if (percent % 10 >= 7 && letter != "A" && letter != "F")
        {
            sign = "+";
        }
        else if (percent % 10 < 3 && letter != "F")
        {
            sign = "-";
        }
        
        Console.WriteLine($"Your letter grade is {letter}{sign}.");

        if (percent >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry you failed the class. You'll do better next time!");
        }
    }
}