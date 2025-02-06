using System;

class Program
{
    static void Main(string[] args)
    {   
        int i = 1;
        while (i < 2)
        {
            Console.WriteLine("Enter the numerator: ");
            string numerator = Console.ReadLine();
            int num = int.Parse(numerator);

            Console.WriteLine("Enter the denominator: ");
            string denominator = Console.ReadLine();
            int den = int.Parse(denominator);

            Fraction fraction1 = new Fraction(num, den);
            
            Console.WriteLine($"{fraction1.GetFractionString()}");
            Console.WriteLine($"{fraction1.GetDecimalValue()}");
        }
    }
}