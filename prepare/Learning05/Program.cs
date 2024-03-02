using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        List<Shape> shapes = new List<Shape>();
        Square square1 = new Square("blue", 4);
        Rectangle rectangle1 = new Rectangle("orange", 3,5);
        Circle circle1 = new Circle("purple", 4);
        shapes.Add(square1);
        shapes.Add(rectangle1);
        shapes.Add(circle1);
        foreach(Shape shape in shapes){
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"Color: {color}\nArea: {area}");
        }
    }
}