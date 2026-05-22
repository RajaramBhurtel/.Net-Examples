using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] names = { "Deepika", "Anu", "Prabesh", "Mohan" };
        var myLinqQuery = from name in names
                          where name.Contains('a')
                          select name;
        foreach (string name in myLinqQuery)
            Console.Write(name + " ");
    }
}