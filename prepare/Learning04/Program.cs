using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.Write("What is your name? ");
        string myName = Console.ReadLine();
        
        bool i = true;
        do
        {
            Console.WriteLine("Enter 'quit' to end program");
            Console.Write("What topic do you want to study? ");
            string myTopic = Console.ReadLine();

            Assignment assign1 = new Assignment(myName, myTopic);

            if (myTopic == "math")
            {
                Console.Write("What section do you want to study? ");
                string mySect = Console.ReadLine();

                Console.Write("What problems do you want to solve? ");
                string myProbs = Console.ReadLine();

                Math math1 = new Math(mySect, myProbs);

                string summary = assign1.GetSummary(myName, myTopic);
                Console.WriteLine($"{summary}");

                string homework = math1.GetHomeworkList(mySect, myProbs);
                Console.WriteLine($"{homework}");
            }
            else if (myTopic == "writing")
            {
                Console.Write("What is the title of the assignment? ");
                string myTitle = Console.ReadLine();
                
                Writing write1 = new Writing(myTitle);

                string summary = assign1.GetSummary(myName, myTopic);
                Console.WriteLine($"{summary}");

                string assigName = write1.GetWritingInfo(myTitle, myTopic);
                Console.WriteLine($"{assigName}");
            }
            else if (myTopic == "quit")
            {
                i = false;
                Console.WriteLine("Goodbye!");
            }
            else 
            {
                Console.WriteLine("Please choose either math or writing");
            }
        }while (i == true);
    }
}