//Example of using Dictionary in C#

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> students = new Dictionary<int, string>();

        // Add
        students.Add(1, "Alice");
        students.Add(2, "Bob");

        // Access
        Console.WriteLine(students[1]);

        // Check
        Console.WriteLine("Has key 3? " + students.ContainsKey(3));

        // Remove
        students.Remove(1);

        // Loop
        foreach (var item in students)
        {
            Console.WriteLine(item.Key + " - " + item.Value);
        }
    }
}