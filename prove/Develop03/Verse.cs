class Verse
{
    public string[] verseList()
    {
        string verse = "And he answered, No. And he said unto him, Yea.";
        string[] words = verse.Split(" ");
        return words;
    }

    public string reference()
    {
        string reference = "Alma 11:29, 33";
        return reference;
    }
}