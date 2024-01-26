namespace ShapeLibrary.Figures;

public class Triangle : Figure
{
    public double A { get; private set; }
    public double B { get; private set; }
    public double C { get; private set; }
    public bool IsSquare
    {
        get
        {
            return A * A + B * B - C * C < 0.00000001;
        }
    }
    public Triangle(double a, double b, double c)
    {
        if (!IsTriangle(a, b, c)) throw new ArgumentException("Треугольник не существует");
        var sides = new List<double> { a, b, c };
        sides.Sort(); // Для простоты будущих операций выполним сортировку 
        A = sides[0];
        B = sides[1];
        C = sides[2];
        _squareCounter = new TriangleSquareCounter();
    }
    /// <summary>
    /// Должно выполняться правило треугольника и стороны должны быть положительными
    /// </summary>
    private bool IsTriangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }
}
