// Simple delegate example
using System;
delegate int MathOperation(int a, int b);
class Program
{
    public static void Main(string[] args)
    {
        MathOperation operation = Add;
        MathOperation operation2 = new MathOperation(Subtract);
        // MathOperation operation2 = Subtract;
        Console.WriteLine(operation(10, 5));
        Console.WriteLine(operation2(10, 5));
    }
    static int Add(int x, int y)
    {
        return x + y;
    }
    static int Subtract(int x, int y)
    {
        return x - y;
    }

}