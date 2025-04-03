class Running : Exercise
{
    private float _distance;
    public Running()
    {
        _distance = 0;
    }
    public Running(float distance1, string date1, float length1)
    {
        _distance = distance1;
        _date = date1;
        _length = length1;
    }
    public float CalcSpeed()
    {
        return (_distance * 60) / _length;
    }
}