class Circle : Shape
{
    private double radius;
    public Circle (string color, double newRadius) : base(color)
    {
        radius = newRadius;
    }

    public override double GetArea(double radius, double not)
    {
        double area = radius * radius * 3.14;
        return area;
    }
}