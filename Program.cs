using System;

class Program
{
    static void Main()
    {
        // Ініціалізація матриці з конкретними значеннями
        int[,] matrix = {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 },
            { 13, 14, 15, 16 }
        };

        // Виклик методу для модифікації матриці
        int[,] modifiedMatrix = ArrayModify(matrix);

        // Виведення модифікованої матриці
        Console.WriteLine("\nМодифікована матриця:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(modifiedMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static int[,] ArrayModify(int[,] a)
    {
        int[,] newArray = (int[,])a.Clone();
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (i == j)
                    newArray[i, j] = 0;
            }
        }

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (i + j == 3)
                    newArray[i, j] = 1;
            }
        }
        return newArray;
    }
}