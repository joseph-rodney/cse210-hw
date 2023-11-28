public class Rectangle : Shape
{
    private double _length;
    private double _width;

    // Get length
    public double SetLength()
    {
        return _length;
    }

    //Set Length
    public void GetLength(double length)
    {
        _length = length;
    }

    //Get Width
    public double SetWidth()
    {
        return _width;
    }

    //Set Width
    public void GetWith(double width)
    {
        _width = width;
    }

    //Override SetArea method
    public override double GetArea()
    {
        return _length * _width;
    }
}