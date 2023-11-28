public class Rectangle : Shape
{
    private double _length;
    private double _width;

    // Get length
    public double GetLength()
    {
        return _length;
    }

    //Set Length
    public void SetLength(double length)
    {
        _length = length;
    }

    //Get Width
    public double GetWidth()
    {
        return _width;
    }

    //Set Width
    public void SetWith(double width)
    {
        _width = width;
    }

    //Override SetArea method
    public override double GetArea()
    {
        return _length * _width;
    }
}