//Example program to demonstrate lambda expressions in C#
using System;
class Program
{
    public delegate int MathOperation(int a, int b);
    static void Message() => Console.WriteLine("Hello from lambda expression");
    static int Add(int a, int b) => a + b;
    static MathOperation Multiply = (int a, int b) =>
    {
        Console.WriteLine("Multiplying");
        return a * b;
    };
    static void Main()
    {
        Message();
        int result = Add(5, 3);
        Console.WriteLine("Result: " + result);
        int product = Multiply(5, 3);
        Console.WriteLine("Product: " + product);
    }
}