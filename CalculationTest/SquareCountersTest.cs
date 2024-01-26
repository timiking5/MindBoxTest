namespace CalculationTest;

public class SquareCountersTest
{
    [Fact]
    public void TriangleCalcSquare_SquareTriangleShouldCalculate()
    {
        // Arrange
        double expected = 6;
        Triangle triangle = new(3, 4, 5);

        // Act
        double actual = triangle.CountSquare();

        //Assert
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void TriangleCalcSquare_CommonTriangleShouldCalculate()
    {
        // Arrange
        double expected = 21.217622d;
        Triangle triangle = new(7, 7, 7);

        // Act
        double actual = triangle.CountSquare();

        // Assert
        Assert.Equal(expected, actual, 5);
    }
    [Fact]
    public void CircleCalcSquare_ShouldCalcSquare()
    {
        // Arrange
        double r = 5.0d;
        double expected = Math.PI * r * r;
        Circle circle = new(r);

        // Act
        double actual = circle.CountSquare();

        // Assert
        Assert.Equal(expected, actual, 5);
    }
}
