using System;

class Program
{
    static void Main()
    {
        // Створимо початковий масив 4x4
        int[,] array = {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 },
            { 13, 14, 15, 16 }
        };
        
        // Виклик функції ArrayModify
        int[,] modifiedArray = ArrayModify(array);
        
        // Виведемо результат
        PrintArray(modifiedArray);
    }

    static int[,] ArrayModify(int[,] a)
    {
        int[,] newArray = a;
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (i == j)
                    newArray[i,j] = 0;
            }
        }
        
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (i + j == 3)
                    newArray[i,j] = 1;
            }
        }
        return newArray;
    }

    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
