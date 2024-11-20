using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("task 1");
        int[,] matrix = new int[8, 8];
        Random rand = new Random();

        Console.WriteLine("Матриця:");
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                matrix[i, j] = rand.Next(-50, 51);
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        int maxAbsValue = Math.Abs(matrix[0, 0]);
        int maxRow = 0, maxCol = 0;

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (Math.Abs(matrix[i, j]) >= maxAbsValue)
                {
                    maxAbsValue = Math.Abs(matrix[i, j]);
                    maxRow = i;
                    maxCol = j;
                }
            }
        }

        Console.WriteLine($"\nМаксимальний по модулю елемент: {matrix[maxRow, maxCol]} на позиції ({maxRow}, {maxCol})");

        int swapCol = (maxCol == 7) ? 0 : maxCol + 1;

        for (int i = 0; i < 8; i++)
        {
            int temp = matrix[i, maxCol];
            matrix[i, maxCol] = matrix[i, swapCol];
            matrix[i, swapCol] = temp;
        }

        Console.WriteLine("\nМатриця після перестановки стовпців:");
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("task 2");
        int N = 30;
        int[] array = new int[N];
        int[] compressedArray = new int[N];
        int count = 0;
        Random rand1 = new Random();

        Console.WriteLine("Початковий масив:");
        for (int i = 0; i < N; i++)
        {
            array[i] = rand.Next(-5, 16);
            Console.Write(array[i] + " ");
        }

        for (int i = 0; i < N; i++)
        {
            if (array[i] != 0)
            {
                compressedArray[count] = array[i];
                count++;
            }
        }

        int[] finalArray = new int[count];
        for (int i = 0; i < count; i++)
        {
            finalArray[i] = compressedArray[i];
        }

        for (int i = 0; i < count - 1; i++)
        {
            for (int j = 0; j < count - i - 1; j++)
            {
                if (finalArray[j] < finalArray[j + 1])
                {
                    int temp = finalArray[j];
                    finalArray[j] = finalArray[j + 1];
                    finalArray[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("\n\nСтиснутий і відсортований масив:");
        for (int i = 0; i < count; i++)
        {
            Console.Write(finalArray[i] + " ");
        }
    }
}