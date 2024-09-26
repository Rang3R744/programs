using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("task 1");
        double a = 5.1;
        double b = 0.9;

        Console.Write("Введіть значення x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        double y;

        if (x <= 1)
        {
            y = Math.Pow(x - 4, 2) + a;
        }
        else if (x > 1 && x <= 2)
        {
            y = 1.7 * Math.Cos(x) * Math.Cos(x);
        }
        else // x > 2
        {
            y = Math.Exp(a * x) * Math.Cos(b * x);
        }

        Console.Write($"Значення y = {y}");
        Console.ReadKey();

        Console.WriteLine("task 2");
        Console.Write("Введіть координати точки A (x1 y1): ");
        var inputA = Console.ReadLine().Split();
        double x1 = Convert.ToDouble(inputA[0]);
        double y1 = Convert.ToDouble(inputA[1]);

        Console.Write("Введіть координати точки B (x2 y2): ");
        var inputB = Console.ReadLine().Split();
        double x2 = Convert.ToDouble(inputB[0]);
        double y2 = Convert.ToDouble(inputB[1]);

        Console.Write("Введіть координати точки C (x3 y3): ");
        var inputC = Console.ReadLine().Split();
        double x3 = Convert.ToDouble(inputC[0]);
        double y3 = Convert.ToDouble(inputC[1]);

        double area = 0.5 * Math.Abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));

        if (area == 0)
        {
            Console.WriteLine("Точки A, B та C розташовані на одній прямій.");
        }
        else
        {
            Console.WriteLine("Точки A, B та C не розташовані на одній прямій.");

            double sideAB = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double sideBC = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double sideCA = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));

            double perimeter = sideAB + sideBC + sideCA;

            Console.WriteLine($"Периметр трикутника ABC: {perimeter}");
            Console.ReadKey();

            Console.WriteLine("task 3");
            Console.Write("Введіть номер пори року (1 - зима, 2 - весна, 3 - літо, 4 - осінь): ");
            int season = Convert.ToInt32(Console.ReadLine());

            switch (season)
            {
                case 1: // Зима
                    Console.WriteLine("Зима:");
                    Console.WriteLine("Грудень - 31 день");
                    Console.WriteLine("Січень - 31 день");
                    Console.WriteLine("Лютий - 28/29 днів (в залежності від року)");
                    break;

                case 2: // Весна
                    Console.WriteLine("Весна:");
                    Console.WriteLine("Березень - 31 день");
                    Console.WriteLine("Квітень - 30 днів");
                    Console.WriteLine("Травень - 31 день");
                    break;

                case 3: // Літо
                    Console.WriteLine("Літо:");
                    Console.WriteLine("Червень - 30 днів");
                    Console.WriteLine("Липень - 31 день");
                    Console.WriteLine("Серпень - 31 день");
                    break;

                case 4: // Осінь
                    Console.WriteLine("Осінь:");
                    Console.WriteLine("Вересень - 30 днів");
                    Console.WriteLine("Жовтень - 31 день");
                    Console.WriteLine("Листопад - 30 днів");
                    break;

                default:
                    Console.WriteLine("Неправильний номер пори року. Введіть число від 1 до 4.");
                    break;
            }
        }
    }
}