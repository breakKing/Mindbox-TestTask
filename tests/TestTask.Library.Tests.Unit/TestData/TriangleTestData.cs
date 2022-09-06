using System.Collections;
using TestTask.Library.Shapes;

namespace TestTask.Library.Tests.Unit.TestData;

public class TriangleTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[]
        {
            new Triangle(3, 4, 5),
            6
        };

        yield return new object[]
        {
            new Triangle(18.33, 16.677, 22.4),
            150.24173498
        };

        yield return new object[]
        {
            new Triangle(1, 1, 1),
            0.43301270
        };
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
