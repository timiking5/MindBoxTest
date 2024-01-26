global using ShapeLibrary.SquareCounters;

namespace ShapeLibrary.Figures;

/// <summary>
/// Я сильно задумался над тем, стоит ли создавать общего родителя для фигур. Также думал,
/// должен ли быть общий предок (для простоты называю его именно предком) интерфейсом или
/// абстрактным классом. Но я всё же посчитал, что общий предок быть должен и он должен быть
/// абстрактным классом, чтобы подчеркнуть взаимосвязь IS. Т.е. Circle IS figure, square IS figure и т.д.
/// </summary>
public abstract class Figure
{
    protected ISquareCounter _squareCounter;  // = null!;

    public double CountSquare()
    {
        return _squareCounter.CalcSquare(this);
    }

}
