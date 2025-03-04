using System.Reflection.Metadata.Ecma335;

class Square : Shape
{
    private double side;
    public Square (string color, double newSide) : base(color)
    {
        side = newSide;
    }

    public override double GetArea(double side, double not)
    {
        double area = side * side;
        return area;
    }
}