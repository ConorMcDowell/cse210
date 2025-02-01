using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;
using Microsoft.VisualBasic;
using System.IO;
class Journal
{

    List<string> answers = new List<string>();
    public void Main()
    {
        PromptGenerator prompt = new PromptGenerator(); 

        DateTime date = DateTime.Now;
        
        prompt.MakeList();
        prompt.Display();
        string ans = Console.ReadLine();
        answers.Add(date.ToString());
        answers.Add(ans);
    }

    public void Display()
    {
        foreach (string answer in answers)
        {
            Console.WriteLine(answer);
        }
    }

    public void Load()
    {
        Console.Write("What file do you want to load? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }

    public void Save()
    {
        Entry entry1 = new Entry();
        Console.Write("What would you like to name the file? ");
        string filename = Console.ReadLine();
        entry1.Save(filename, answers);
    }
}