class Rectangle : Shape
{
    private double side1;
    private double side2;
    public Rectangle (string color, double newSide1, double newSide2) : base(color)
    {
        side1 = newSide1;
        side2 = newSide2;
    }

    public override double GetArea(double side1, double side2)
    {
        double area = side1 * side2;
        return area;
    }
}