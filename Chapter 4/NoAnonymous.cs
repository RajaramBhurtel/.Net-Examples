//Example of using named method as delegate
using System;
class Program
{
    delegate void MessageDelegate();
    static void ShowMessage()
    {
        Console.WriteLine("Hello from named method");
    }
    static void Main()
    {
        MessageDelegate msg = ShowMessage;
        msg();
    }
}