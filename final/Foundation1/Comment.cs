class Comment
{
    private string _name;
    private string _text;
    public Comment(string name1, string text1)
    {
        _name = name1;
        _text = text1;
    }

    public string GetName()
    {
        return _name;
    }
    public string GetText()
    {
        return _text;
    }
}