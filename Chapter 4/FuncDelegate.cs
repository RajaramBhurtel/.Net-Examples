// Example of using Func delegate with a named method
using System;
class Program
{
    public static int Sum(int x, int y)
    {
        return x + y;
    }
    static void Main()
    {
        Func<int, int, int> addDelegate = Sum;  // param1, param2, return type

        int result = addDelegate(15, 25);
        Console.WriteLine($"Result: {result}"); // Output: 40
    }

}
