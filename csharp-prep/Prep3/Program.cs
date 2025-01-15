using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int mag_num = randomGenerator.Next(1, 100);

        int guess_num;
        int i = 1;
        do
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            guess_num = int.Parse(guess);

            if (guess_num > mag_num)
            {
                Console.WriteLine("Lower");
                i++;
            }
            else if (guess_num < mag_num)
            {
                Console.WriteLine("Higher");
                i++;
            }
            else if (guess_num == mag_num)
            {
                Console.WriteLine("That's Correct!");
                Console.WriteLine($"It took you {i} guesses.");
                Console.Write("Would you like to play again?");
                string ans = Console.ReadLine();
                if (ans == "yes")
                {
                    Main(args);
                }
                else
                {
                    Console.WriteLine("Goodbye!");
                }
            }
            
        }while (mag_num != guess_num);
    }

}