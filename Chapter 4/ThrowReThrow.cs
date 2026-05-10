//Example of throwing and re-throwing exceptions in C#
using System;
class Program
{
    static void Main()
    {
        try
        {
            CheckAge(15);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Handled in Main: " + ex.Message);
        }

        Console.WriteLine("Program continues...");
    }
    static void CheckAge(int age)
    {
        try
        {
            if (age < 18)
            {
                throw new Exception("Age must be 18 or above.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Handled inside CheckAge: " + ex.Message);
            // throw;
        }
    }
}