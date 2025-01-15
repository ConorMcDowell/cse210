using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers. To stop, type 0.");

        int num;
        int sum = 0;
        int max = 0;
        int total = 0;
        do
        {
            Console.Write("Enter a number: ");
            string number = Console.ReadLine();
            num = int.Parse(number);
            numbers.Add(num);
        } while(num != 0);
        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
            total = i;
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        float avg = ((float) sum / numbers.Count);

        Console.WriteLine($"The sum of the numbers is: {sum}");
        Console.WriteLine($"The max of the numbers is: {max}");
        Console.WriteLine($"The average of the numbers is: {avg}");
    }
}