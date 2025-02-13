using System.ComponentModel;

class Word
{
    public string[] hideWords(string[] words)
    {
        for (int i = 0; i < words.Length; i++)
        {
            Random random = new Random();
            int random1 = random.Next(1, 10);
            
            if (random1 > 5)
            {
                words[i] = "_";
            }
        }
        return words;
    }
}