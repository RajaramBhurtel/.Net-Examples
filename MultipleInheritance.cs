// Example of Multiple Inheritance in C# using Interfaces
using System;

interface IShape
{
    void Draw();
}

interface IColor
{
    void Color();
}

class Circle : IShape, IColor
{
    public void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }

    public void Color()
    {
        Console.WriteLine("Applying color to the circle");
    }
}

class Program
{
    static void Main()
    {
        Circle circle = new Circle();
        circle.Draw();
        circle.Color();
    }
}