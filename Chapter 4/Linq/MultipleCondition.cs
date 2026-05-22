// Multiple Condition in Linq
using System;
using System.Collections.Generic;
using System.Linq;

namespace BCA
{
    class LinqTest
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Ram", "Shyam", "Hari", "Gita" };

            // Multiple Condition
            var result = names.Where(s => s.Contains("Ram") || s.Contains("Gita"));

            foreach (string val in result)
            {
                Console.WriteLine(val);
            }
            Console.ReadLine();
        }
    }
}