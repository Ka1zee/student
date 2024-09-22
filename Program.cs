using System;

class Program
{
    static void Main()
    {
        // Ініціалізація двох матриць
        int[,] matrixA = {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 },
            { 13, 14, 15, 16 }
        };

        int[,] matrixB = {
            { 16, 15, 14, 13 },
            { 12, 11, 10, 9 },
            { 8, 7, 6, 5 },
            { 4, 3, 2, 1 }
        };

        // Додавання матриць
        int[,] sumMatrix = AddMatrices(matrixA, matrixB);
        Console.WriteLine("Сума матриць:");
        PrintMatrix(sumMatrix);

        // Множення матриць
        int[,] productMatrix = MultiplyMatrices(matrixA, matrixB);
        Console.WriteLine("\nДобуток матриць:");
        PrintMatrix(productMatrix);
    }

    static int[,] AddMatrices(int[,] a, int[,] b)
    {
        int[,] result = new int[4, 4];
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                result[i, j] = a[i, j] + b[i, j];
            }
        }
        return result;
    }

    static int[,] MultiplyMatrices(int[,] a, int[,] b)
    {
        int[,] result = new int[4, 4];
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                result[i, j] = 0; // Ініціалізація для накопичення
                for (int k = 0; k < 4; k++)
                {
                    result[i, j] += a[i, k] * b[k, j];
                }
            }
        }
        return result;
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
