class Exercise
{
    protected string _date;
    protected float _length;
    protected Exercise ()
    {
        _date = " ";
        _length = 0;
    }
    protected Exercise (string date1, float length1)
    {
        _date = date1;
        _length = length1;
    }
    public virtual float CalcPace(float distance)
    {
        return (_length / distance) / 60;
    }
    public virtual string GetSummary(string type, float distance, float speed, float pace)
    {
        return $"{_date} {type} ({_length} min): Distance: {distance} km, Speed: {speed}km/h, Pace: {pace}h/km";
    }
}