using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using Microsoft.Win32;
using System.Windows;

class Program
{
    static void Main(string[] args)
    {
        //Extra Functionality: The user can input a scripture to memorize
        Console.Write("Please enter your scripture: ");
        string scrip = Console.ReadLine();

        Console.Write("Please enter your scripture's reference: ");
        string name = Console.ReadLine();

        Scripture scripture1 = new Scripture();
        scripture1.Display1(scrip, name);

        Word word1 = new Word();
        Verse verse1 = new Verse();
        string[] words = word1.hideWords(verse1.verseList(scrip));
        bool i = false;

        do
        {
            Console.Write("Press enter to continue or type 'quit' to finish");
            string ans = Console.ReadLine();

            if (ans == "quit")
            {
                Console.WriteLine("Goodbye!");
                i = true;
            }

            else
            {
                Console.Clear();

                scripture1.Display2(words, name);
                words = word1.hideWords(words);
            }

        }while (i == false);
    }
}