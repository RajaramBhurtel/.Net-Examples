// C# Sealed Classes and Methods Example
class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    public sealed override void Speak()
    {
        Console.WriteLine("Dog barks");
    }
}

class Puppy : Dog
{
    // will cause compile-time error
    public override void Speak()
    {
        Console.WriteLine("Puppy barks softly");
    }
}

// Sealed class (cannot be inherited)
sealed class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}

// This will cause error because Calculator is sealed
class AdvancedCalculator : Calculator
{
}

class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Animal();
        animal.Speak();

        Dog dog = new Dog();
        dog.Speak();

        Calculator calc = new Calculator();
        int result = calc.Add(10, 20);

        Console.WriteLine("Sum = " + result);
    }
}