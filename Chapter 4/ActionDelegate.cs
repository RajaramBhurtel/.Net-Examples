//
using System;
class Program
{
    static void PrintMessage(string msg)
    {
        Console.WriteLine(msg);
    }
    static void PrintI(int i)
    {
        Console.WriteLine(i);
    }
    static void Main()
    {
        Action<string> printer = PrintMessage;
        printer("Hello from the Action delegate!");

        Action<int> printNumber = PrintI;
        printNumber(42);
    }


}
