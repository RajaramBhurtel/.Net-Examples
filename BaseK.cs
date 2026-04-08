// Example of using base keyword in C# to access members of the base class from a derived class.

using System;
class Animal
{
    public string type = "Animal";
    public Animal(string name)
    {
        Console.WriteLine("Animal name: " + name);
    }
    public virtual void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}

class Dog : Animal
{
    public Dog(string name) : base(name)
    {
        Console.WriteLine("Dog constructor called");
    }
    public override void Speak()
    {
        base.Speak();
        Console.WriteLine("Dog barks");
    }
    public void ShowType()
    {
        Console.WriteLine("Type from base class: " + base.type);
    }
}

class Program
{
    static void Main()
    {
        Dog d = new Dog("Buddy");

        d.ShowType();
        d.Speak();
    }
}