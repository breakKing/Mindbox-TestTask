using FluentAssertions;
using TestTask.Library.Common;
using TestTask.Library.Shapes;
using TestTask.Library.Tests.Unit.TestData;

namespace TestTask.Library.Tests.Unit;

public class CircleTests
{
    [Theory]
    [ClassData(typeof(CircleTestData))]
    public void GetArea_ShouldReturnCorrectAnswer(Circle circle, double expectedArea)
    {
        // Assign
        
        
        // Act
        var area = circle.GetArea();
        
        // Assert
        area.Should().BeApproximately(expectedArea, DoubleExtensions.ERROR);
    }
}
