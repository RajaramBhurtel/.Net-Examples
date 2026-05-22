//Example of using anonymous method as delegate
using System;
class Program
{
    delegate void MessageDelegate(int a);
    static void Main()
    {
        MessageDelegate msg = delegate (int a)
        {
            Console.WriteLine("Hello from anonymous method" + a);
            Console.WriteLine(a * a);
        };
        msg(5);
    }
}