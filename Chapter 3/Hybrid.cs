// Example of Hybrid Inheritance in C# using Classes and Interfaces

using System;

interface IShape
{
    void Draw();
}

class Shape
{
    public void Display()
    {
        Console.WriteLine("Shape is displayed.");
    }
}

class Circle : Shape, IShape
{
    public void Draw()
    {
        Console.WriteLine("Circle is drawn.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle();
        circle.Display(); // Output: Shape is displayed.
        circle.Draw(); // Output: Circle is drawn.
    }
}