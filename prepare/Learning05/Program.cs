using System;

class Program
{
    static void Main(string[] args)
    {
        //Square Object
        Square square = new Square();
        // square.SetColor("Red");
        square.SetColor("Red");
        square.SetSide(3);

        // Print Square Object
        Console.WriteLine($"Area: {square.GetArea()} \nColor:{square.GetColor}");

        //Rectangle Object
        Rectangle rectangle = new Rectangle();
        rectangle.SetColor("Blue");
        rectangle.SetLength(6);
        rectangle.SetWith(2);

        //Print Rectangle Object
        Console.WriteLine($"Area: {rectangle.GetArea()} \nColor: {rectangle.GetColor()}");

        //Rectangle Object
        Circle circle = new Circle();
        circle.SetColor("Green");
        circle.SetRadius(10);

        //Print Circle Object
        Console.WriteLine($"Area: {circle.GetArea()} \nColor: {circle.GetColor()}");
        
    }
}