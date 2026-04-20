// Example of automatic properties in C#
using System;

class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int EmployeeId { get; }
    public string Department { get; set; } = "Not Assigned";

    public Employee(int id, string name, int age)
    {
        EmployeeId = id;
        Name = name;
        Age = age;
    }

    public void Display()
    {
        Console.WriteLine($"ID: {EmployeeId}, Name: {Name}, Age: {Age}, Dept: {Department}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee(101, "Alice", 28);
        emp.Department = "IT";
        emp.Display();

    }
}