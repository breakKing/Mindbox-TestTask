using TestTask.Library.Common;

namespace TestTask.Library.Shapes;

public class Triangle : Shape
{
    private double[] sides = new double[] { 0.0, 0.0, 0.0 };
    public double[] Sides
    {
        get
        {
            return sides;
        }
        set
        {
            if (value.Length != 3)
            {
                throw new ArgumentException("Triangle must have three sides", nameof(value));
            }

            if (value.Any(s => s <= 0.0))
            {
                throw new ArgumentException("Triangle must have positive side lengths", nameof(value));
            }

            var sidesSum = value.Sum();
            // Если хоть одна сторона короче, чем суммарная длина двух других, то треугольник не существует
            if (value.Any(s => sidesSum - s <= s))
            {
                throw new ArgumentException("Triangle with such side lengths cannot exist", nameof(value));
            }

            sides = value;
        }
    }

    public Triangle(params double[] sides)
    {
        Sides = sides;
    }

    public override double GetArea()
    {
        var semiPerimeter = GetPerimeter() / 2.0;

        var mult1 = semiPerimeter - Sides[0];
        var mult2 = semiPerimeter - Sides[1];
        var mult3 = semiPerimeter - Sides[2];

        var area = Math.Sqrt(semiPerimeter * mult1 * mult2 * mult3);

        return area;
    }

    public bool IsRightAngleTriangle()
    {
        if (PythagoreanTheoremHolds(Sides[0], Sides[1], Sides[2]))
        {
            return true;
        }

        if (PythagoreanTheoremHolds(Sides[0], Sides[2], Sides[1]))
        {
            return true;
        }

        if (PythagoreanTheoremHolds(Sides[1], Sides[2], Sides[0]))
        {
            return true;
        }

        return false;
    }

    private double GetPerimeter()
    {
        return Sides[0] + Sides[1] + Sides[2];
    }

    private bool PythagoreanTheoremHolds(double side1, double side2, double hypotenuse)
    {
        var sumOfSquaredSides = (side1 * side1) + (side2 * side2);
        return sumOfSquaredSides.IsEqualToWithAnError(hypotenuse * hypotenuse);
    }
}
