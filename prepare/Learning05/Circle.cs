public class Circle : Shape
{
    private double _radius;

    //Constructor to accept radius and color
    public Circle(string color, double radius): base(color)
    {
        _radius = radius;
    }

    // Override GetArea Method
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }

}