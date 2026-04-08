// Example of interface implementation in C#.
using System;

interface inter1
{
	void display();
}
class InterfaceImpl : inter1
{

	public void display()
	{
		Console.WriteLine("Demonstration of interface");
	}

	public static void Main(String[] args)
	{
		InterfaceImpl t = new InterfaceImpl();
		t.display();
	}
}