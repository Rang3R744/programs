using System;

public interface IGraphicPrimitive
{
    void Draw();
}

public class Line : IGraphicPrimitive
{
    public void Draw() => Console.WriteLine("Drawing a Line");
}

public class Circle : IGraphicPrimitive
{
    public void Draw() => Console.WriteLine("Drawing a Circle");
}

public class Rectangle : IGraphicPrimitive
{
    public void Draw() => Console.WriteLine("Drawing a Rectangle");
}

public class Demo2
{
    public static void Run()
    {
        IGraphicPrimitive[] shapes =
        {
            new Line(),
            new Circle(),
            new Rectangle()
        };

        foreach (var s in shapes)
            s.Draw();
    }
}
