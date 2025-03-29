class Swimming : Exercise
{
    private int _laps;
    public Swimming ()
    {
        _laps = 0;
    }
    public Swimming (int laps1, string date1, float length1)
    {
        _laps = laps1;
        _date = date1;
        _length = length1;
    }
    public float CalcDistance()
    {
        return _laps;
    }
    public float CalcSpeed()
    {
        return (CalcDistance() * 60) /  _length;
    }
    public override string GetSummary(string type, float distance, float speed, float pace)
    {
        return $"{_date} {type} ({_length} min): Distance: {distance} laps, Speed: {speed}laps/h, Pace: {pace}h/lap";
    }
}