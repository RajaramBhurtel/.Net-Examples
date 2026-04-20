using System;

class Program
{
    static void Print<T>(T value)
    {
        Console.WriteLine("Type: " + typeof(T).Name);
        Console.WriteLine(value);
    }

    static void Swap<T>(ref T a, ref T b)
    {
        Console.WriteLine("Before swapping: a = " + a + ", b = " + b);
        T temp = a;
        a = b;
        b = temp;

        Console.WriteLine("After swapping: a = " + a + ", b = " + b);
    }

    static void Main()
    {
        Print<int>(10);
        Print<string>("Hello");

        int x = 5, y = 10;
        Swap(ref x, ref y);

        string s1 = "A", s2 = "B";
        Swap(ref s1, ref s2);
    }
}