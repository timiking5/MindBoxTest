namespace ShapeLibrary.Figures;

public class Circle : Figure
{
    public double Radius { get; private set; }
    public Circle(double r)
    {
        if (r < 0)
        {
            throw new ArgumentException("Радиус не может быть отрицательным");
        }
        _squareCounter = new CircleSquareCounter();
        Radius = r;
    }
}
