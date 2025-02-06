class Fraction
{
    private int _top;
    private int _bottom;
    public Fraction ()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction (int num)
    {
        _top = num;
        _bottom = 1;
    }
    public Fraction (int num, int den)
    {
        _top = num;
        _bottom = den;
    }

    public int GetTopNum ()
    {
        return _top;
    }
    public int GetBottomNum ()
    {
        return _bottom;
    }
    public void SetTopNum (int numerator)
    {
        _top = numerator;
    }
    public void SetBottomNum (int denominator)
    {
        _bottom = denominator;
    }

    public string GetFractionString ()
    {
        return $"{GetTopNum()}/{GetBottomNum()}";
    }
    public double GetDecimalValue ()
    {
        return (double)_top / (double)_bottom;
    }
}