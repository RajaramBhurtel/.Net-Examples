// Example of Generic Delegates
using System;
public delegate T DisplayMessage(T message);  // Generic delegate declaration
class Program
{
    static void Main()
    {
        DisplayMessage messageDelegate = new DisplayMessage(Display);
        string result = messageDelegate("Hello from Generic Delegate!");
        Console.WriteLine(result);
    }
    static string Display(string message)
    {
        return message;
    }
}
