// Example of Static Class and Static Members in C#
using System;
static class MathUtility
{
    public static int count = 0;
    public static int Add(int a, int b)
    {
        count++;
        return a + b;
    }
    public static int Multiply(int a, int b)
    {
        count++;
        return a * b;
    }
}

class Program
{
    static void Main()
    {
        int sum = MathUtility.Add(5, 3);
        int product = MathUtility.Multiply(4, 2);

        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Product: " + product);

        Console.WriteLine("Operations performed: " + MathUtility.count);

        Console.ReadLine();
    }
}