using System;

class Car1
{
    public string Brand;
    public int Year;

    public Car1()
    {
        Brand = "Unknown";
        Year = 0;
    }

    public Car1(string brand)
    {
        Brand = brand;
        Year = 0;
    }

    public Car1(string brand, int year)
    {
        Brand = brand;
        Year = year;
    }
}

class Program1
{
    static void Main()
    {
        Car1 car1 = new Car1();
        Console.WriteLine(car1.Brand + " " + car1.Year);
        // Output: Unknown 0

        Car1 car2 = new Car1("Toyota");
        Console.WriteLine(car2.Brand + " " + car2.Year);
        // Output: Toyota 0

        Car1 car3 = new Car1("Honda", 2022);
        Console.WriteLine(car3.Brand + " " + car3.Year);
        // Output: Honda 2022
    }
}