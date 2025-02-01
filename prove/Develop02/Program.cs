using System;
using System.ComponentModel.Design;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        Menu menu1 = new Menu();
        string choice = "";
        Journal journal1 = new Journal();

        while (choice != "5")
        {
            menu1.Display();
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();
            
            if (choice == "1")
            {
                journal1.Main();
            }
            else if (choice == "2")
            {
                journal1.Display();
            }
            else if (choice == "3")
            {
                journal1.Load();
            }
            else if (choice == "4")
            {
                journal1.Save();
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Please enter a number 1-5");
            }
        }
    }
} 