using System;

class Program
{
    static void Main(string[] args)
    {
        // Notice that the list is a list of "Shape" objects. That means
        // you can put any Shape objects in there, and also, any object where
        // the class inherits from Shape
        List<Shape> shapes = new List<Shape>();
            //Square Object
            Square square = new Square("Red", 3);
            shapes.Add(square);

            //Rectangle Object
            Rectangle rectangle = new Rectangle("Blue", 6, 2);
            shapes.Add(rectangle);

            //Rectangle Object
            Circle circle = new Circle("Green", 10);
            shapes.Add(circle);
        
        //Iterate through the list of shapes
        foreach (Shape shape in shapes)
        {
             // Notice that all shapes have a GetColor method from the base class
            string color = shape.GetColor();

            // Notice that all shapes have a GetArea method, but the behavior is
            // different for each type of shape
            double area = shape.GetArea();

            // Print the color and area for all shapes
            Console.WriteLine($"Area: {area} \nColor: {color}\n");
        }
    }
}