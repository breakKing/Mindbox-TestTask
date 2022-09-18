namespace TestTask.Library.Common;

public abstract class Shape
{
    public abstract double GetArea();

    public static double GetArea<TShape>(TShape shape)
        where TShape : Shape
    {
        return shape.GetArea();
    }
}
