class LinqTest
{
    static void Main(string[] args)
    {
        List<string> names = new List<string>() { "Ram", "Shyam", "Hari" };
        List<string> address = new List<string>() { "Btm", "Ktm", "Btm" };

        // using union
        var result = names.Union(address);

        foreach (var res in result)
        {
            Console.WriteLine(res);
        }
        Console.ReadLine();
    }
}