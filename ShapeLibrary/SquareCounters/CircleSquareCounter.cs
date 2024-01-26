namespace ShapeLibrary.SquareCounters;

public class CircleSquareCounter : ISquareCounter
{
    public double CalcSquare(Figure figure)
    {
        if (figure is Circle circle)
        {
            return Math.PI * Math.Pow(circle.Radius, 2);
        }
        else
        {
            throw new ArgumentException("CircleSquareCounter может только подсчитать площадь круга");
        }
    }
}
