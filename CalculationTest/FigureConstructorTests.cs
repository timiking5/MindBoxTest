namespace CalculationTest;

public class FigureConstructorTests
{
    [Fact]
    public void Circle_ShouldCreateCircle()
    {
        // Arrange
        double r = 5.0d;

        // Act
        var exception = Record.Exception(() => new Circle(r));

        // Act
        Assert.Null(exception);
    }
    [Fact]
    public void Circle_ShouldThrowArgumentException()
    {
        // Arrange
        double r = -5.0d;

        // Act & Arrange
        Assert.Throws<ArgumentException>(() => new Circle(r));
    }
    [Fact]
    public void Triangle_ShouldCreateTriangle()
    {
        // Arrange
        double a = 3.0d, b = 4.0d, c = 5.0d;

        // Act
        var exception = Record.Exception(() => new Triangle(a, b, c));

        // Assert
        Assert.Null(exception);
    }
    [Fact]
    public void Triangle_ShouldThrowArgumentException()
    {
        // Arrange
        double a = 3.0d, b = 4.0d, c = 15.0d;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }
}
