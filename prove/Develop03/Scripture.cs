using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Scripture
{
    private string scripture;
    private string refName;
    private string[] listWords;

    public Scripture()
    {
        scripture = "And he answered, No. And he said unto him, Yea.";
        refName = "Alma 11:29, 33";
        listWords = scripture.Split(" ");
    }

    public void Display1(string scrip, string name)
    {
        if (scrip == "")
        {
            scrip = scripture;
        }
        else
        {
            scripture = scrip;
        }
        if (name == "")
        {
            name = refName;
        }
        else
        {
            refName = name;
        }

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
        if (name == "")
        {
            name = refName;
        }
        else
        {
            refName = name;
        }
        if (words[0] == "")
        {
            words = listWords;
        }
        else
        {
            listWords = words;
        }
        
        Verse verse1 = new Verse();
        
        foreach (string word in words)
        {
            Console.Write($"{word} ");
        }

        string reference = verse1.reference(name);
        Console.WriteLine($"{reference}");
    }
}