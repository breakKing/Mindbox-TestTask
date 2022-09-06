using FluentAssertions;
using TestTask.Library.Common;
using TestTask.Library.Shapes;
using TestTask.Library.Tests.Unit.TestData;

namespace TestTask.Library.Tests.Unit;

public class TriangleTests
{
    [Theory]
    [ClassData(typeof(TriangleTestData))]
    public void GetArea_ShouldReturnCorrectAnswer(Triangle triangle, double expectedArea)
    {
        // Assign
        
        
        // Act
        var area = triangle.GetArea();
        
        // Assert
        area.Should().BeApproximately(expectedArea, DoubleExtensions.ERROR);
    }
}
