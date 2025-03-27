class Event
{
    protected string _name;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;
    protected string _type;
    protected Event ()
    {
        _name = " ";
        _description = " ";
        _date = " ";
        _time = " ";
        _address = " ";
        _type = " ";
    }
    protected Event (string name1, string description1, string date1, string time1, string address1, string type1)
    {
        _name = name1;
        _description = description1;
        _date = date1;
        _time = time1;
        _address = address1;
        _type = type1;
    }
    public string StandardDetail()
    {
        return $"{_name}, {_description}, {_date}, {_time}, {_address}";
    }
    public virtual string FullDetail()
    {
        string stand = StandardDetail();
        return $"{stand}, {_type}";
    }
    public string Short()
    {
        return $"{_type}, {_name}, {_date}";
    }
}