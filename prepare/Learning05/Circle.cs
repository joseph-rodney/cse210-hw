public class Circle : Shape
{
    private double _radius;

    public Circle()
    {

    }

    //Constructor to accept radius and color
    public double GetRadius()
    {
        return _radius;
    }

    public void SetRadius(double radius)
    {
        _radius = radius;
    }

    // Override GetArea Method
    public override double GetArea()
    {
        return base.GetArea();
    }

}