class Lecture : Event
{
    private string _speaker;
    private int _capacity;
    public Lecture(string speaker1, int capacity1, string name1, string description1, string date1, string time1, string address1, string type1)
    {
        _speaker = speaker1;
        _capacity = capacity1;
        _name = name1;
        _description = description1;
        _date = date1;
        _time = time1;
        _address = address1;
        _type = type1;
    }
    public override string FullDetail() 
    {
        string basic = base.FullDetail();
        return $"{basic}, {_speaker}, {_capacity}";
    }
}