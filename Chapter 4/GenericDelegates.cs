// Example of Generic Delegates
using System;

public delegate T DisplayMessage<T>(T message);  // Generic delegate declaration
class Program
{
    static void Main()
    {
        DisplayMessage<string> messageDelegate = new DisplayMessage<string>(Display);
        string result = messageDelegate("Hello from Generic Delegate!");
        Console.WriteLine(result);
        DisplayMessage<int> messageDelegate1 = new DisplayMessage<int>(Display);

        Console.WriteLine(messageDelegate1(10));  // Using the same delegate for int type
    }
    static string Display(string message)
    {
        return message;
    }

    static int Display(int number)
    {
        return number * 2;
    }
}
