class Assignment 
{
    private string _studentName = "John Doe";
    private string _topic = "Academics";

    public Assignment(string myName, string myTopic)
    {
        _studentName = myName;
        _topic = myTopic;
    }

    public string GetSummary(string myName, string myTopic)
    {
        myName = _studentName;
        myTopic = _topic;

        string summary = myName + " - " + myTopic;

        return summary;
    }
}