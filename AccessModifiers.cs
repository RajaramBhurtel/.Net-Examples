//Example of access modifiers in C#
using System;
class BaseClass
{
    public int pub = 1;
    private int priv = 2;
    protected int prot = 3;
    internal int inter = 4;
    protected internal int protInternal = 5;
    private protected int privProt = 6;

    public void ShowBase()
    {
        Console.WriteLine(priv);
        Console.WriteLine(privProt);
    }
}
class DerivedClass : BaseClass
{
    public void ShowDerived()
    {
        Console.WriteLine(pub);
        Console.WriteLine(prot);
        Console.WriteLine(inter);
        Console.WriteLine(protInternal);
        Console.WriteLine(privProt);

        // Console.WriteLine(priv); // private (not accessible)
    }
}

class Program
{
    static void Main()
    {
        BaseClass obj = new BaseClass();

        Console.WriteLine(obj.pub);
        Console.WriteLine(obj.inter);
        Console.WriteLine(obj.protInternal);

        // Console.WriteLine(obj.prot);     // protected not accessible here
        // Console.WriteLine(obj.priv);     // private not accessible here
        // Console.WriteLine(obj.privProt); // not accessible here

        DerivedClass d = new DerivedClass();
        d.ShowDerived();
    }
}