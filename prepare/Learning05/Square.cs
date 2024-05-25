using System.Runtime.CompilerServices;

public class Square : Shape
{
    public Square(string color, double side) : base(color)
    {
        _color = color;
        _side = side;
    }
    private string _color;
    private double _side;

    public override double GetArea()
    {
        return _side * _side;
    }
}