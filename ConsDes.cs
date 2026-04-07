class ConsDes
{
    //constructor
    public ConsDes(string message)
    {
        Console.WriteLine(message);
    }
    public void test()
    {
        Console.WriteLine("This is a method");
    }
    //destructor
    ~ConsDes()
    {
        Console.WriteLine("This is a destructor");
        Console.ReadKey();
    }
}
class Construct
{
    static void Main(string[] args)
    {
        string msg = "This is a constructor";
        ConsDes obj = new ConsDes(msg);
        obj.test();
    }
}