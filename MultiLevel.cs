// Example of Multi-Level Inheritance in C#

using System;

class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

class Mammal : Animal
{
    public void Drink()
    {
        Console.WriteLine("Mammal is drinking.");
    }
}

class Dog : Mammal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog();
        myDog.Eat();
        myDog.Drink();
        myDog.Bark();
    }
}