// Example of Multicast Delegates
using System;
namespace MulticastDemo
{
    delegate void MultiDelegate(string message);
    class Program
    {
        public static void Main(string[] args)
        {
            MultiDelegate del = null;
            del += DisplayMessage1;
            del += DisplayMessage2;
            del += DisplayMessage3;
            del("Hello Students!");
        }
        static void DisplayMessage1(string msg)
        {
            Console.WriteLine("Method 1: " + msg);
        }
        static void DisplayMessage2(string msg)
        {
            Console.WriteLine("Method 2: " + msg);
        }
        static void DisplayMessage3(string msg)
        {
            Console.WriteLine("Method 3: " + msg);
        }
    }
}