// Example of Instance Delegates
using System;
namespace DelegateDemo
{
    delegate void NotifyDelegate(string message);

    class Program
    {
        public static void Main(string[] args)
        {
            // Create object first
            Student student = new Student();

            // Mapping with Instance Method
            NotifyDelegate del = new NotifyDelegate(student.DisplayMessageInstance);
            // OR shorter way
            // NotifyDelegate del = student.DisplayMessageInstance;

            del("Hello from Instance Method!");
        }
    }

    class Student
    
    {
        // Instance Method
        public void DisplayMessageInstance(string msg)
        {
            Console.WriteLine("Instance Method: " + msg);
        }
    }
}