//Example of using anonymous method as delegate
using System;
class Program
{
    delegate void MessageDelegate();
    static void Main()
    {
        MessageDelegate msg = delegate ()
        {
            Console.WriteLine("Hello from anonymous method");
        };
        msg();
    }
}