//Example of ArrayList in C#
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList list = new ArrayList();

        // Add (different types allowed)
        list.Add(10);
        list.Add("Hello");

        // Access (requires casting)
        int num = (int)list[0];
        Console.WriteLine(num);

        // Remove
        list.Remove(10);

        // Loop
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}