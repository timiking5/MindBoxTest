﻿global using ShapeLibrary.Figures;

namespace ShapeLibrary.SquareCounters;

/// <summary>
/// Я долго думал, как бы элегантно реализовать такую вязь и решил воспользоваться паттерном Bridge(мост).
/// Таким образом, у нас есть 2 параллельные иерархии классов.
/// Плюсы:
/// 1) В каждой фигуре (круг, треугольник) у нас реализован только минимальный функционал,
/// связанный непосредственно с фигурой - стороны, или радиус, или т.п. Таким образом выполняется принцип
/// S - single responsibility. Для иерархии классов счётчиков площади также выполняется SRP.
/// 2) Повышение степени расширяемости. 2 Иерархии классов могут расширяться независимо
/// 3) Сокрытие деталей реализации от клиентов
/// (См. Паттерны Объектно-Ориентированного Программирования с.184)
/// </summary>
public interface ISquareCounter
{
    double CalcSquare(Figure figure);
}
