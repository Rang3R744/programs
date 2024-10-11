using System;

Console.WriteLine("task 1");
Console.Write("Введіть двозначне число N: ");
int N;

while (!int.TryParse(Console.ReadLine(), out N) || N < 10 || N > 99)
{
    Console.WriteLine("Будь ласка, введіть коректне двозначне число.");
}

int sum = 0;
Console.WriteLine($"Кратні 3 числа від 1 до {N}:");

for (int i = 1; i <= N; i++)
{
    if (i % 3 == 0)
    {
        Console.WriteLine(i);
        sum += i;
    }
}

Console.WriteLine($"Сума кратних 3: {sum}");
Console.ReadKey();

Console.WriteLine("task 2");
double x = 1.0;
double S1 = 0.0;
double S2 = 0.0;
double tolerance = 1e-7;
int n = 1; // Ітератор
int maxIterations = 1000;

Console.WriteLine("Номер ітерації | Поточний член | Накопичена сума | Похибка");

while (n <= maxIterations)
{
    S2 = (Math.Pow(n, Math.Sqrt(n)) - x) / Factorial(n);

    S1 += S2;

    Console.WriteLine($"{n,15} | {S2,15:F10} | {S1,15:F10} | {Math.Abs(S2 / S1),15:F10}");

    if (Math.Abs(S2 / S1) < tolerance)
        break;

    n++;
}

Console.WriteLine($"Фінальна сума: {S1}");
    {

    int number = 1;
    long factorial = Factorial(number);
}

static long Factorial(int n)
{
    if (n == 0 || n == 1) return 1;
    long result = 1;
    for (int i = 2; i <= n; i++)
    {
        result *= i;
    }
    return result;
}
Console.WriteLine("task 3");
{
    double a = 0.3;
    double b = 7.3;
    double h = 0.2;

    Console.WriteLine("  x\t\t  y = cos(x) / x\t  z = cos(x / 2)");
    Console.WriteLine("----------------------------------------------");

    for (double x1 = a; x <= b; x += h)
    {
        double y = CalculateY(x);
        double z = CalculateZ(x);
        Console.WriteLine($"{x:F2}\t\t{y:F10}\t{z:F10}");
    }
}

static double CalculateY(double x)
{
    return Math.Cos(x) / x;
}

static double CalculateZ(double x)
{
    return Math.Cos(x / 2);
}