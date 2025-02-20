using System.Dynamic;

class Math : Assignment
{
    private string _textbookSection = "0.0";
    private string _problems = "0";

    public Math(string mySect, string myProbs) : base("name", "topic")
    {
        _textbookSection = mySect;
        _problems = myProbs;
    }

    public string GetHomeworkList(string mySect, string myProbs)
    {
        string homework = "Section" + " " + mySect + " " + "Problems" + " " + myProbs;

        return homework;
    }
}