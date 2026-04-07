using System;

class Student
{
    int id;
    string name;

    // Constructor 1 (default) → calls another constructor
    public Student() : this(0, "Unknown")
    {
        Console.WriteLine("Default constructor called");
    }

    // Constructor 2 (parameterized)
    public Student(int id, string name)
    {
        // Distinguishing class members from parameters
        this.id = id;
        this.name = name;
    }

    // Method to display values
    public void Display()
    {
        // Accessing current object's fields
        Console.WriteLine("ID: " + this.id);
        Console.WriteLine("Name: " + this.name);
    }
    public void Print(Student obj)
    {
        Console.WriteLine("Method called");
    }

    public void Start()
    {
        this.Print(this); // passing current object
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student(); // calls default constructor
        s.Display();
    }
}