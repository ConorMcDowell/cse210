class Cycling : Exercise
{
    private float _speed;
    public Cycling ()
    {
        _speed = 0; 
    }
    public Cycling (float speed1, string date1, float length1)
    {
        _speed = speed1;
        _date = date1;
        _length = length1;
    }
    public float CalcDistance()
    {
        return (_length * _speed) / 60;
    }
}