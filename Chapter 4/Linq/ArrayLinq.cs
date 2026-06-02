using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] names = { "Deepika", "Anu", "Prabesh", "Mohan" };
        // var myLinqQuery = from name in names
        //                   where name.Contains('a')
        //                   select name;
        var myLinqQuery = names.Where(name => name.Contains('a'));
        foreach (string name in myLinqQuery)
            Console.Write(name + " ");
    }
}