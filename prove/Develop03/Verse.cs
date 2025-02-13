class Verse
{
    private string scripture;
    private string refName;

    public Verse()
    {
        scripture = "And he answered, No. And he said unto him, Yea.";
        refName = "Alma 11:29, 33";
    }

    public string[] verseList(string scrip)
    {
        scripture = scrip;
        string[] words = scrip.Split(" ");
        return words;
    }

    public string reference(string name)
    {
        refName = name;
        return name;
    }
}