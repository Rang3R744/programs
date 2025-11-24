using System;

public class Fraction
{
    public int Num { get; set; }
    public int Den { get; set; }

    public Fraction(int num, int den)
    {
        Num = num;
        Den = den == 0 ? 1 : den;
    }

    public override string ToString() => $"{Num}/{Den}";
}

public class FractionOperations
{
    public Fraction Add(Fraction a, Fraction b)
    {
        return new Fraction(
            a.Num * b.Den + b.Num * a.Den,
            a.Den * b.Den
        );
    }

    public Fraction Add(Fraction a, double b)
    {
        Fraction temp = new Fraction((int)(b * a.Den), a.Den);
        return Add(a, temp);
    }

    public Fraction Add(Fraction a, int numerator, int denominator)
    {
        return Add(a, new Fraction(numerator, denominator));
    }
}

public class Demo4
{
    public static void Run()
    {
        FractionOperations ops = new FractionOperations();

        var f1 = new Fraction(1, 2);
        var f2 = new Fraction(1, 3);

        Console.WriteLine("Add fraction + fraction = " + ops.Add(f1, f2));
        Console.WriteLine("Add fraction + double = " + ops.Add(f1, 0.5));
        Console.WriteLine("Add fraction + (int,int) = " + ops.Add(f1, 3, 4));
    }
}
