class LinqTest
{
    static void Main(string[] args)
    {
        List<int> marks = new List<int>() { 10, 30, 50, 20, 5 };

        int max = marks.Max();
        int min = marks.Min();
        int sum = marks.Sum();
        int total = marks.Count();

        Console.WriteLine("Maximum marks=" + max);
        Console.WriteLine("Minimum marks=" + min);
        Console.WriteLine("Sum of marks=" + sum);
        Console.WriteLine("Total Count=" + total);

        Console.ReadLine();
    }
}