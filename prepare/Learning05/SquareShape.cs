// create square class inherits the shape class
public class SquareShape : Shape
{
    // Orivatr side attribute
    private double _side;

    // Constructor that accepts color and side
    public SquareShape(double side) : base("Red")
    {
        _side = side;
    }

    //Over ride GetArea Method
    public override double GetArea()
    {
       return _side * _side;
    }
}