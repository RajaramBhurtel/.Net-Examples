// Example of constructors in C#

using System;
class Car
{
    public string Brand { get; set; }
    public static int CarCount;
    static Car()
    {
        CarCount = 0;
        Console.WriteLine("Static constructor called");
    }
    private Car(bool isPrivate)
    {
        Brand = "Private Brand";
        CarCount++;
    }
    public static Car CreatePrivateCar()
    {
        return new Car(true);
    }
    public Car()
    {
        Brand = "Unknown";
        CarCount++;
    }
    public Car(string brand)
    {
        Brand = brand;
        CarCount++;
    }
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
        Car car1 = new Car();
        Console.WriteLine("Car1 Brand: " + car1.Brand);

        Car car2 = new Car("Toyota");
        Console.WriteLine("Car2 Brand: " + car2.Brand);

        Car car3 = new Car(car2);
        Console.WriteLine("Car3 Brand (copied): " + car3.Brand);

        Car car4 = Car.CreatePrivateCar();
        Console.WriteLine("Car4 Brand (private): " + car4.Brand);

        Console.WriteLine("Total Cars Created: " + Car.CarCount);
    }
}