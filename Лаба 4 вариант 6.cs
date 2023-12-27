using System;
using System.Collections.Generic;
using System.Linq;

// Класс "Треугольник"
abstract class Shape
{
    public abstract double CalculateArea();
}
class Triangle : Shape
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public override double CalculateArea()
    {
        double p = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
    }
}

// Класс "Прямоугольник"
class Rectangle : Shape
{
    public double SideA { get; set; }
    public double SideB { get; set; }

    public override double CalculateArea()
    {
        return SideA * SideB;
    }
}

class ListShapes : List<Shape>
{
    public double CalculateAreaAll()
    {
        var LINQ = from shape in this select shape.CalculateArea();
        return LINQ.Sum();
    }
}

class Program
{
    static void Main()
    {
        ListShapes ListShapes = new ListShapes
        {
            new Triangle { SideA = 3, SideB = 4, SideC = 5 },
            new Triangle { SideA = 5, SideB = 5, SideC = 5 },
            new Rectangle { SideA = 4, SideB = 6 },
            new Rectangle { SideA = 2, SideB = 8 },
            new Triangle { SideA = 7, SideB = 8, SideC = 10 }
        };

        Console.WriteLine("Суммарная площадь всех фигур: " + ListShapes.CalculateAreaAll());

    }
}
