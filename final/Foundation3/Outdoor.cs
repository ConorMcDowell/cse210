class Outdoor : Event
{
    private string _weather;
    public Outdoor (string weather1, string name1, string description1, string date1, string time1, string address1, string type1)
    {
        _weather = weather1;
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
        return $"{basic}, {_weather}";
    }
}