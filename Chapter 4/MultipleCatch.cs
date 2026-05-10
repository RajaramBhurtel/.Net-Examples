//Example of handling Try-Catch in C#
using System;
class Program
{
    static void Main()
    {
        try
        {
            int[] arr = { 1, 2, 3 };
            Console.WriteLine(arr[5]); // IndexOutOfRangeException
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Array index is out of range.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Some other exception occurred.");
        }
    }
}