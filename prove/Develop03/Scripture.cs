using System.Runtime.CompilerServices;

class Scripture
{
    public void Display1()
    {
        Verse verse1 = new Verse();

        string[] verseList = verse1.verseList();
        string reference = verse1.reference();
        
        foreach (string word in verseList)
        {
            Console.Write($"{word} ");
        }
        
        Console.WriteLine($"{reference}");
    }
    public void Display2(string[] words)
    {
        Verse verse1 = new Verse();
        
        foreach (string word in words)
        {
            Console.Write($"{word} ");
        }

        string reference = verse1.reference();
        Console.WriteLine($"{reference}");
    }
}