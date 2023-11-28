using System.Threading.Tasks.Dataflow;

public class Shape{
    // color member variable
    protected string _color;

    // Constructor to accept color and sets it
    public Shape(string color)
    {
        _color = color;
    }

    public virtual double GetArea()
    {
        return 1;
    }

}