class Writing : Assignment
{
    private string _title = "lotr";

    public Writing(string myTitle) : base("name", "topic")
    {
        _title = myTitle;
    }

    public string GetWritingInfo(string myTitle, string _topic)
    {
        string assigName = _topic + " - " + myTitle;
        return assigName;
    }
}