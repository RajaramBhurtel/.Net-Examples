//Example of Operator Overloading in C#
class Point
{
    public int X;
    public int Y;
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    public static Point operator +(Point p1, Point p2)
    {
        return new Point(p1.X + p2.X, p1.Y + p2.Y);
    }
    public static Point operator +(Point p)
    {
        return new Point(+p.X, +p.Y);
    }
    public static bool operator ==(Point p1, Point p2)
    {
        return p1.X == p2.X && p1.Y == p2.Y;
    }

    // Required when overloading ==
    public static bool operator !=(Point p1, Point p2)
    {
        return !(p1 == p2);
    }
    public override bool Equals(object obj)
    {
        if (obj is Point p)
        {
            return this == p;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return (X, Y).GetHashCode();
    }

    public void Display()
    {
        Console.WriteLine($"({X}, {Y})");
    }
}

class Program
{
    static void Main()
    {
        Point p1 = new Point(2, 3);
        Point p2 = new Point(4, 5);

        Point p3 = p1 + p2;
        p3.Display(); // (6,8)

        Point p5 = +p1;
        p5.Display(); // (2,3)

        Point p6 = new Point(2, 3);
        Console.WriteLine(p1 == p6); // true
        Console.WriteLine(p1 == p2); // false
    }
}