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

    [Theory]
    [InlineData(new double[] {-1, 1, 1})]
    [InlineData(new double[] {0, 0, 0})]
    [InlineData(new double[] {1, 1, 3})]
    [InlineData(new double[] {1, 2, 3, 4})]
    public void Constructor_ShouldThrow_WhenSidesAreNotCorrect(double[] sides)
    {
        // Assign
        
        
        // Act
        Action act = () => new Triangle(sides);
        
        // Assert
        act.Should().Throw<ArgumentException>();
    }

    [Theory]
    [InlineData(new double[] {3, 4, 5}, true)]
    [InlineData(new double[] {4, 5, 3}, true)]
    [InlineData(new double[] {6, 9, 7}, false)]
    [InlineData(new double[] {13, 19, 18}, false)]
    public void IsRightAngleTriangle_ShouldReturnCorrectResult(double[] sides, bool expected)
    {
        // Assign
        var triangle = new Triangle(sides);
        
        // Act
        var result = triangle.IsRightAngleTriangle();
        
        // Assert
        result.Should().Be(expected);
    }
}
