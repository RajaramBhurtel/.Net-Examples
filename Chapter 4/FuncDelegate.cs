// Example of using Func delegate with a named method
using System;
class Program
{
    public static int Sum(int x, int y)
    {
        return x + y;
    }
    public static string Greet(string name, int age)
    {
        return $"Hello, {name}! You are {age} years old.";
    }
    static void Main()
    {
        Func<int, int, int> addDelegate = Sum;  // param1, param2, return type

        int result = addDelegate(15, 25);
        Console.WriteLine($"Result: {result}"); // Output: 40
        Func<string, int, string> greetDelegate = Greet;  // param1, param2, return type
        string greetResult = greetDelegate("Alice", 30);
        Console.WriteLine(greetResult); // Output: Hello, Alice! You are 30 years old.
    }

}
