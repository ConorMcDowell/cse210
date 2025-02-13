class Verse
{
    public string[] verseList(string scrip)
    {
        string[] words = scrip.Split(" ");
        return words;
    }

    public string reference(string name)
    {
        return name;
    }
}