using System;

class Program1
{
    static void Main()
    {
        Console.WriteLine("task 1");
        int length = 12;
        int[] array = new int[length];

        Random random = new Random();
        for (int i = 0; i < length; i++)
        {
            array[i] = random.Next(-5, 10);
        }

        Console.WriteLine("Вихідний масив:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        long product = 1;
        bool hasOdd = false;

        for (int i = 0; i < length; i++)
        {
            if (array[i] % 2 != 0)
            {
                product *= array[i];
                hasOdd = true;
            }
        }

        if (hasOdd)
        {
            Console.WriteLine("Добуток непарних елементів масиву: " + product);
        }
        else
        {
            Console.WriteLine("У масиві немає непарних елементів.");
        }
        Console.ReadKey();

        Console.WriteLine("task 2");
        Console.Write("Введіть довжину масиву: ");
        int length1 = int.Parse(Console.ReadLine());

        int[] array1 = new int[length1];
        Random random1 = new Random();

        for (int i = 0; i < length1; i++)
        {
            array1[i] = random1.Next(-5, 16); 
        }

        Console.WriteLine("Вихідний масив:");
        for (int i = 0; i < length1; i++)
        {
            Console.Write(array1[i] + " ");
        }
        Console.WriteLine();

        for (int i = 0; i < length1; i++)
        {
            if (array1[i] > 0) 
            {
                for (int j = 0; j < length1; j++)
                {
                    if (array1[j] == -array1[i])
                    {
                        array1[i] = -array1[i];
                        array1[j] = -array1[j];
                    }
                }
            }
        }

        Console.WriteLine("Оброблений масив:");
        for (int i = 0; i < length1; i++)
        {
            Console.Write(array1[i] + " ");
        }
        Console.WriteLine();
    }
}
