using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        bool i = true;

        while (i == true)
        {
            Console.WriteLine("Choose your event type: ");
            Console.WriteLine("1. Lecture");
            Console.WriteLine("2. Reception");
            Console.WriteLine("3. Outdoor");
            Console.WriteLine("4. Quit");
            Console.Write("Your Choice: ");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("What is the title of your event? ");
            string name = Console.ReadLine();
            Console.Write("What is a brief description of your event? ");
            string description = Console.ReadLine();
            Console.Write("What is the date of your event? ");
            string date = Console.ReadLine();
            Console.Write("What time will your event take place? ");
            string time = Console.ReadLine();
            Console.Write("What is the address where your event will take place? ");
            string address = Console.ReadLine();

            string type;
            bool j = true;
            int choose;

            if (choice == 1)
            {
                type = "Lecture";
                Console.Write("Who is the speaker? ");
                string speaker = Console.ReadLine();
                Console.Write("What is the capacity? ");
                int capacity = int.Parse(Console.ReadLine());

                Lecture lecture1 = new Lecture(speaker, capacity, name, description, date, time, address, type);

                while (j == true)
                {
                    Console.WriteLine("What would you like to see? ");
                    Console.WriteLine("1. Standard Details");
                    Console.WriteLine("2. Full Details");
                    Console.WriteLine("3. Short Desciption");
                    Console.WriteLine("4. Quit");
                    Console.Write("Your Choice: ");
                    choose = int.Parse(Console.ReadLine());

                    if (choose == 1)
                    {
                        Console.WriteLine(lecture1.StandardDetail());
                    }
                    else if (choose == 2)
                    {
                        Console.WriteLine(lecture1.FullDetail());
                    }
                    else if (choose == 3)
                    {
                        Console.WriteLine(lecture1.Short());
                    }
                    else if (choose == 4)
                    {
                        j = false;
                    }
                    else 
                    {
                        Console.WriteLine(" ");
                    }
                }
            }
            else if (choice == 2)
            {
                type = "Reception";
                Console.Write("What is the email? ");
                string email = Console.ReadLine();

                Reception reception1 = new Reception(email, name, description, date, time, address, type);

                while (j == true)
                {
                    Console.WriteLine("What would you like to see? ");
                    Console.WriteLine("1. Standard Details");
                    Console.WriteLine("2. Full Details");
                    Console.WriteLine("3. Short Desciption");
                    Console.WriteLine("4. Quit");
                    Console.Write("Your Choice: ");
                    choose = int.Parse(Console.ReadLine());

                    if (choose == 1)
                    {
                        Console.WriteLine(reception1.StandardDetail());
                    }
                    else if (choose == 2)
                    {
                        Console.WriteLine(reception1.FullDetail());
                    }
                    else if (choose == 3)
                    {
                        Console.WriteLine(reception1.Short());
                    }
                    else if (choose == 4)
                    {
                        j = false;
                    }
                    else 
                    {
                        Console.WriteLine(" ");
                    }
                }
            }
            else if (choice == 3)
            {
                type = "Outdoor";
                Console.Write("What is the weather? ");
                string weather = Console.ReadLine();

                Outdoor outdoor1 = new Outdoor(weather, name, description, date, time, address, type);

                while (j == true)
                {
                    Console.WriteLine("What would you like to see? ");
                    Console.WriteLine("1. Standard Details");
                    Console.WriteLine("2. Full Details");
                    Console.WriteLine("3. Short Desciption");
                    Console.WriteLine("4. Quit");
                    Console.Write("Your Choice: ");
                    choose = int.Parse(Console.ReadLine());

                    if (choose == 1)
                    {
                        Console.WriteLine(outdoor1.StandardDetail());
                    }
                    else if (choose == 2)
                    {
                        Console.WriteLine(outdoor1.FullDetail());
                    }
                    else if (choose == 3)
                    {
                        Console.WriteLine(outdoor1.Short());
                    }
                    else if (choose == 4)
                    {
                        j = false;
                    }
                    else 
                    {
                        Console.WriteLine(" ");
                    }
                }
            }
            else if (choice == 4)
            {
                i = false;
                Console.WriteLine("Goodbye!");
            }
            else 
            {
                Console.WriteLine(" ");
            }
        }

    }
}