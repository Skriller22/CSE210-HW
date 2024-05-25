using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("red", 5);
        Rectangle rectangle = new Rectangle("green", 5, 10);
        Circle circle = new Circle("black", 5);

        List<Shape> shapeList = new List<Shape>();
        shapeList.Add(square);
        shapeList.Add(rectangle);
        shapeList.Add(circle);

        foreach (Shape shape in shapeList)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}