// create square class inherits the shape class
public class Square : Shape
{
    // Private side attribute
    private double _side;

    public Square()
    {

    }

    // Constructor that accepts color and side
   public double GetSide()
   {
        return _side;
   }

   public void SetSide(double side)
   {
        _side = side;
   }

    //Over ride GetArea Method
    public override double GetArea()
    {
       return _side * _side;
    }
}