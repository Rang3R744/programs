using System;

public class Point3D
{
    public double X, Y, Z;

    public Point3D(double x, double y, double z)
    {
        X = x; Y = y; Z = z;
    }

    public override string ToString() => $"({X}, {Y}, {Z})";
}

public class PointProcessor
{
    public void ProcessPoints(Point3D p)
    {
        Console.WriteLine($"Processing single point {p}");
    }

    public void ProcessPoints(Point3D p1, Point3D p2)
    {
        Console.WriteLine($"Distance = {Distance(p1, p2):F2}");
    }

    public void ProcessPoints(Point3D[] points)
    {
        Console.WriteLine($"Processing array of {points.Length} points");
    }

    private double Distance(Point3D a, Point3D b)
    {
        return Math.Sqrt(
            Math.Pow(a.X - b.X, 2) +
            Math.Pow(a.Y - b.Y, 2) +
            Math.Pow(a.Z - b.Z, 2)
        );
    }
}

public class Demo3
{
    public static void Run()
    {
        PointProcessor processor = new PointProcessor();

        processor.ProcessPoints(new Point3D(1, 2, 3));
        processor.ProcessPoints(new Point3D(1, 0, 0), new Point3D(0, 1, 0));
        processor.ProcessPoints(new Point3D[]
        {
            new Point3D(1,1,1), new Point3D(2,2,2), new Point3D(3,3,3)
        });
    }
}
