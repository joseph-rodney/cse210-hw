using System;

class Program
{
    static void Main(string[] args)
    {
        //List to hold all the shapes
        List<Shape> shapes = new List<Shape>();
            //Square Object
            Square square = new Square();
            square.SetColor("Red");
            square.SetSide(3);
            shapes.Add(square);

            //Rectangle Object
            Rectangle rectangle = new Rectangle();
            rectangle.SetColor("Blue");
            rectangle.SetLength(6);
            rectangle.SetWith(2);
            shapes.Add(rectangle);

            //Rectangle Object
            Circle circle = new Circle();
            circle.SetColor("Green");
            circle.SetRadius(10);
            shapes.Add(circle);
        
        //Iterate through the list of shapes
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Area: {shape.GetArea()} \nColor: {shape.GetColor()}\n");
        }
    }
}