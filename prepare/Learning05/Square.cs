// create square class inherits the shape class
public class Square : Shape
{
    // Private side attribute
    private double _side;

    // Constructor that accepts color and side
    public Square(string color, double side): base(color)
    {
        _side = side;
    }

    //Over ride GetArea Method
    public override double GetArea()
    {
       return _side * _side;
    }
}