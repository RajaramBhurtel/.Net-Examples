using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // string collection
        List<string> stringList = new List<string>() {
            "C# Tutorials", "VB.NET Tutorials", "Learn C++", "MVC Tutorials", "Java"
        };
        // LINQ Query Syntax
        var result = from s in stringList
                     where s.Contains("Tutorials")
                     select s;

        // LINQ Method Syntax
        // var result = stringList.Where(s => s.Contains("Tutorials"));

        foreach (string value in result)
            Console.Write(value + " ");
    }
}