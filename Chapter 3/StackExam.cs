//Example of Stack in C#
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> stack = new Stack<string>();

        // Add
        stack.Push("Page1");
        stack.Push("Page2");
        stack.Push("Page3");

        // View
        Console.WriteLine("Current: " + stack.Peek());

        // Remove
        Console.WriteLine("Back: " + stack.Pop());

        // Remaining items
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
    }
}