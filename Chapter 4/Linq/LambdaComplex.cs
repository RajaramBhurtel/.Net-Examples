// Lamdba Expression with Linq
using System;
using System.Collections.Generic;
using System.Linq;

class Dog
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class demo
{
    static void Main()
    {
        List<Dog> dogs = new List<Dog>() {
            new Dog { Name = "Rex", Age = 4 },
            new Dog { Name = "Sean", Age = 0 },
            new Dog { Name = "Stacy", Age = 3 }
        };
        //Select Method
        var names = dogs.Select(x => x.Name);

        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
        //OrderByDescending Method
        var sortedDogs = dogs.OrderByDescending(x => x.Age);

        foreach (var dog in sortedDogs)
        {
            Console.WriteLine("Dog {0} is {1} years old.", dog.Name, dog.Age);
        }
        Console.Read();
    }
}