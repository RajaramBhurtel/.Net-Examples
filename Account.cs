// Example of method overriding in C#. 
public class Account
{
    public virtual int balance()
    {
        return 10;
    }
}
public class Amount : Account
{
    public override int balance()
    {
        return 500;
    }
}
class Test
{
    static void Main()
    {
        Amount obj = new Amount();
        int balance = obj.balance();
        Console.WriteLine("Balance is: " + balance);
        Console.ReadKey();
    }
}
