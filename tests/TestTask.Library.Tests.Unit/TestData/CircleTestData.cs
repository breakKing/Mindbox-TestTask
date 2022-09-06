using System.Collections;
using TestTask.Library.Shapes;

namespace TestTask.Library.Tests.Unit.TestData;

public class CircleTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[]
        {
            new Circle(16),
            804.24771932
        };

        yield return new object[]
        {
            new Circle(8.123),
            207.29211333
        };

        yield return new object[]
        {
            new Circle(1),
            3.14159265
        };
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

