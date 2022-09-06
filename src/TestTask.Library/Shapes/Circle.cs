using TestTask.Library.Common;

namespace TestTask.Library.Shapes;

public class Circle : Shape
{
    private double radius = 0.0;
    public double Radius
    {
        get
        {
            return radius;
        }
        set
        {
            if (value <= 0.0)
            {
                throw new ArgumentException("Circle must have positive radius", nameof(value));
            }

            radius = value;
        }
    }
    
    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}
