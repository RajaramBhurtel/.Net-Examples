//Example of try-catch-finally in C#
using System;
class Program
{
    static void Main()
    {
        try
        {
            int x = 0;
            int result = 10 / x;
            Console.WriteLine(result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Division by zero detected.");
        }
        finally
        {
            Console.WriteLine("This block always executes.");
        }
    }
}