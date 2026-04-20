// Example of using GetType() and typeof() in C#
using System;
class Animal { }
class Dog : Animal { }

class Program
{
    static void Main()
    {
        Animal a = new Dog();

        Console.WriteLine(a.GetType());
        Console.WriteLine(typeof(Animal));

        Console.WriteLine(a.GetType() == typeof(Dog));
    }
}