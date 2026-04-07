// Example of Constructor Overloading in C#
using System;

class Car1
{
    public string Brand;
    public int Year;

    public Car1()
    {
        Brand = "Thar";
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
    public Car1(int year)
    {
        Brand = "Unknown";
        Year = year;
    }
    public Car1(int year, string brand)
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

        Car1 car2 = new Car1("Toyota");
        Console.WriteLine(car2.Brand + " " + car2.Year);

        Car1 car3 = new Car1("Honda", 2022);
        Console.WriteLine(car3.Brand + " " + car3.Year);

        Car1 car4 = new Car1(2020);
        Console.WriteLine(car4.Brand + " " + car4.Year);

        Car1 car5 = new Car1(2023, "Ford");
        Console.WriteLine(car5.Brand + " " + car5.Year);

        Console.ReadLine();
    }
}