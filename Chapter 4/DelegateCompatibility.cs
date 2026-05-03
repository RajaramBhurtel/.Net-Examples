// Example of Delegate Compatibility (Covariance and Contravariance)
using System;
namespace CompatibilityDemo
{
    class Animal
    {
        public void Eat() => Console.WriteLine("Eating");
    }
    class Dog : Animal
    {
        public void Bark() => Console.WriteLine("Barking");
    }
    delegate Animal GetAnimalDel();
    delegate void ProcessDogDel(Dog d);
    class Program
    {
        public static void Main(string[] args)
        {
            // Covariance Example
            GetAnimalDel del1 = GetDog;           // Dog is derived from Animal

            // Contravariance Example
            ProcessDogDel del2 = ProcessAnimal;   // Animal is base of Dog

            del1().Eat();
            del2(new Dog());
        }

        static Dog GetDog() => new Dog();

        static void ProcessAnimal(Animal a)
        {
            a.Eat();
        }
    }
}