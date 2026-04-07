// Example of properties in C#

namespace TestNamespace
{
    public class Person
    {
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public static void Main()
        {
            Person person = new Person();
            person.Age = 25;  // Set the age
            Console.WriteLine(person.Age);  // Get and print the age: 25
        }
    }
}