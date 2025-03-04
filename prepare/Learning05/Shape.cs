class Shape
{
    private string color;
    public Shape (string newColor)
    {
        color = newColor;
    }

    public string GetColor()
    {
        return color;
    }

    public virtual double GetArea(double side, double side1)
    {
        return 1;
    }
}