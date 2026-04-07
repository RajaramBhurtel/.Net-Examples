using System;

class Car
{
    public string Brand { get; set; }
    public static int CarCount;

    // 1. Static Constructor (called once)
    static Car()
    {
        CarCount = 0;
        Console.WriteLine("Static constructor called");
    }

    // 2. Private Constructor
    private Car(bool isPrivate)
    {
        Brand = "Private Brand";
        CarCount++;
    }

    // Factory method to access private constructor
    public static Car CreatePrivateCar()
    {
        return new Car(true);
    }

    // 3. Default Constructor
    public Car()
    {
        Brand = "Unknown";
        CarCount++;
    }

    // 4. Parameterized Constructor
    public Car(string brand)
    {
        Brand = brand;
        CarCount++;
    }

    // 5. Copy Constructor
    public Car(Car other)
    {
        Brand = other.Brand;
        CarCount++;
    }
}

class Program
{
    static void Main()
    {
        // Default constructor
        Car car1 = new Car();
        Console.WriteLine("Car1 Brand: " + car1.Brand);

        // Parameterized constructor
        Car car2 = new Car("Toyota");
        Console.WriteLine("Car2 Brand: " + car2.Brand);

        // Copy constructor
        Car car3 = new Car(car2);
        Console.WriteLine("Car3 Brand (copied): " + car3.Brand);

        // Private constructor (via factory method)
        Car car4 = Car.CreatePrivateCar();
        Console.WriteLine("Car4 Brand (private): " + car4.Brand);

        // Static property
        Console.WriteLine("Total Cars Created: " + Car.CarCount);
    }
}