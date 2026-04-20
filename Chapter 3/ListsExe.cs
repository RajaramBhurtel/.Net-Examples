// Example of using a generic List in C#
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        // Add
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);

        // Insert
        numbers.Insert(1, 15);

        // Display
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        // Remove
        numbers.Remove(20);

        // Check
        Console.WriteLine("Contains 10? " + numbers.Contains(10));

        // Access
        Console.WriteLine("First item: " + numbers[0]);
    }
}