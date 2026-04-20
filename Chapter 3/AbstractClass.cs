// Example of abstract class in C#
using System;
public abstract class BaseClass
{
    public abstract void Display();
    public int AddTwoNumbers(int Num1, int Num2)
    {
        return Num1 + Num2;
    }

}
public class Child1 : BaseClass
{
    public override void Display()
    {
        Console.WriteLine("class Child1");
    }
}
public class Child2 : BaseClass
{
    public override void Display()
    {
        Console.WriteLine("class Child2");
    }
}
public class Geeks
{

    public static void Main()
    {
        BaseClass b;
        b = new Child1();
        b.Display();
        b = new Child2();
        b.Display();
        Console.WriteLine("Addition: {0}", b.AddTwoNumbers(4, 6));
    }
}