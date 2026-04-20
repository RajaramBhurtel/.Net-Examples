// Example of upcasting and downcasting in C#:
class Shape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
}
class Circle : Shape
{
    public void DrawCircle()
    {
        Console.WriteLine("Drawing a circle");
    }
}
class Square : Shape
{
    public void DrawSquare()
    {
        Console.WriteLine("Drawing a square");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Circle circle = new Circle();
        Shape shape = circle;   // Upcasting (implicit)
        shape.Draw();           // Works
        //shape.DrawCircle();  // Not accessible

        Shape shape2 = new Circle();
        Circle c = (Circle)shape2; // Downcasting (explicit)
        c.DrawCircle();

        if (shape2 is Circle c1)
        {
            c1.DrawCircle();     // Safe downcasting
        }

        Circle c2 = shape2 as Circle;
        if (c2 != null)
        {
            c2.DrawCircle();    // Safe
        }
        Shape shape4 = new Square();
        // Wrong cast: Square → Circle
        Circle wrong = (Circle)shape4;

        wrong.DrawCircle(); // Will not execute

        // Shape shape5 = new Shape();
        // Circle wrong2 = (Circle)shape5; // Runtime error
    }
}