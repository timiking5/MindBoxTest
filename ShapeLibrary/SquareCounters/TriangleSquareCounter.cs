namespace ShapeLibrary.SquareCounters;

public class TriangleSquareCounter : ISquareCounter
{
    public double CalcSquare(Figure figure)
    {
        if (figure is not Triangle)
        {
            throw new ArgumentException("TriangleSquareCounter может только подсчитать площадь треугольника");
        }
        var triangle = (Triangle)figure;
        if (triangle.IsSquare)
        {
            return CalcSquareTriangle(triangle);
        }
        return CalcCommonTriangle(triangle);
    }
    private double CalcSquareTriangle(Triangle triangle)
    {
        return triangle.A * triangle.B / 2;
    }
    private double CalcCommonTriangle(Triangle triangle)
    {
        var p = (triangle.A + triangle.B + triangle.C) * 0.5;
        return Math.Sqrt(p * (p - triangle.A) * (p - triangle.B) * (p - triangle.C));
    }
}
