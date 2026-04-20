// Queue Example in C#
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> queue = new Queue<string>();

        // Add
        queue.Enqueue("Task1");
        queue.Enqueue("Task2");
        queue.Enqueue("Task3");

        // View
        Console.WriteLine("Next: " + queue.Peek());

        // Remove
        Console.WriteLine("Processing: " + queue.Dequeue());

        // Remaining items
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }
    }
}