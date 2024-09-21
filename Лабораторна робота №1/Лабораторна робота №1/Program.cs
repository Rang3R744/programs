using System;


class Program
{

    static void Main(string[] args)
    {
        //task 1
        Console.Write("Введіть ваше прізвище:");
        string прізвище = Console.ReadLine();

        Console.Write("Введіть ваше ім'я:");
        string ім_я = Console.ReadLine();

        Console.Write("Введіть ваш вік:");
        int вік = Convert.ToInt32(Console.ReadLine());
        string речення = $"Мене звати {прізвище} {ім_я}, мені {вік} років.";
        Console.WriteLine(речення);
        Console.ReadKey();
    
        //task 2
        double a = 3, b = 10;
        Console.WriteLine($"Відповідь: {(Math.Pow(a - b, 4) - (Math.Pow(a, 4) - 4 * Math.Pow(a, 3) * b + 6 * Math.Pow(a, 2) * Math.Pow(b, 2))) / (Math.Pow(b, 4) - 4 * a * Math.Pow(b, 3))}");
        Console.ReadKey();


        //task 3
        int input, output;
        Console.Write("Введіть трьохцифрове число:");
        input = Convert.ToInt32(Console.ReadLine());
        output = (input % 10 * 100 + (input % 100 / 10 * 10) + (input / 100));
        {
            Console.WriteLine($"{input} --> {output}");
            Console.ReadKey();
        }
    }
}