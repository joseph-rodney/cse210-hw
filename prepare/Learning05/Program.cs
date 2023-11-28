using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square();
        square.SetColor("Red");
        square.SetSide(3);
        square.GetSide();

        // Print Square Object
        Console.WriteLine($"Area: {square.GetArea()}");
    }
}