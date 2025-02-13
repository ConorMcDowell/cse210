using System.Runtime.CompilerServices;

class Scripture
{
    public void Display1(string scrip, string name)
    {
        Verse verse1 = new Verse();

        string[] verseList = verse1.verseList(scrip);
        string reference = verse1.reference(name);
        
        foreach (string word in verseList)
        {
            Console.Write($"{word} ");
        }
        
        Console.WriteLine($"{reference}");
    }
    public void Display2(string[] words, string name)
    {
        Verse verse1 = new Verse();
        
        foreach (string word in words)
        {
            Console.Write($"{word} ");
        }

        string reference = verse1.reference(name);
        Console.WriteLine($"{reference}");
    }
}