// Example of Single Inheritance in C#
using System;

class Animal
{
    public void Eat()
    {
        Console.WriteLine("The animal is eating.");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("The dog is barking.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog();
        myDog.Eat(); // Inherited from Animal class
        myDog.Bark(); // Defined in Dog class

        Console.ReadKey(); // Keep the console window open
    }
}