namespace ShapeLibrary;

public class Circle : Figure
{
    public int Radius { get; set; }
    public Circle(int r, ISquareCounter squareCounter) : base(squareCounter)
    {
        Radius = r;
    }
}
