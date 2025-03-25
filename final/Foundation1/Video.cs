class Video
{
    private string _title;
    private string _author;
    private int _length;
    List<Comment> cmnts = new List<Comment>();
    public Video(string title1, string author1, int length1)
    {
        _title = title1;
        _author = author1;
        _length = length1;
    }
    public string GetTitle()
    {
        return _title;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public int GetLength()
    {
        return _length;
    }
    public void NewComment(string name, string text)
    {
        Comment comm1 = new Comment(name, text);
        cmnts.Add(comm1);
    }
    public int NumberComments()
    {
        int count = 0;
        foreach (Comment comm in cmnts)
        {
            count += 1;
        }
        return count;
    }
    public void Display()
    {
        foreach (Comment comment in cmnts)
        {
            string name = comment.GetName();
            string text = comment.GetText();
            Console.WriteLine($"{name} wrote: {text}");
        }
    }
}