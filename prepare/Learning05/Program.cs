using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        string color = "red";
        double side1 = 14.5;
        double side2 = 3.9;
        
        Square square1 = new Square(color, side1);
        Circle circle1 = new Circle(color, side1);
        Rectangle rectangle1 = new Rectangle(color, side1, side2);
        
        shapes.Add(square1);
        shapes.Add(circle1);
        shapes.Add(rectangle1);

        foreach(Shape i in shapes)
        {
            color = i.GetColor();
            double area = i.GetArea(side1, side2);
            Console.WriteLine($"{color} {area}");
        }
    }
}