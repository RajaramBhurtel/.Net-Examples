// Example of Instance and Static Delegates
using System;
namespace DelegateDemo
{
    delegate void NotifyDelegate(string message);

    class Program
    {
        public static void Main(string[] args)
        {
            // 1. Mapping with Static Method
            NotifyDelegate del1 = DisplayStatic;

            // 2. Mapping with Instance Method
            Student s1 = new Student();
            NotifyDelegate del2 = s1.DisplayInstance;

            // Multicast - Both together
            NotifyDelegate multi = null;
            multi += del1;
            multi += del2;

            multi("Welcome to C# Class!");
        }

        // Static Method
        static void DisplayStatic(string msg)
        {
            Console.WriteLine("[Static] " + msg);
        }
    }

    class Student
    {
        // Instance Method
        public void DisplayInstance(string msg)
        {
            Console.WriteLine("[Instance] " + msg);
        }
    }
}