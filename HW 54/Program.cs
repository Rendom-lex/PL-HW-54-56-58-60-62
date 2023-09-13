// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using System;
class Program
{
    static void Main()
    {
        int[,] randomArray = GenerateRandomArray(3, 4);
        Console.WriteLine("Изначальный массив:");
        PrintArray(randomArray);
        SortRowsDescending(randomArray);
        Console.WriteLine("\nСортированный массив:");
        PrintArray(randomArray);
    }
    static int[,] GenerateRandomArray(int numRows, int numCols)
    {
        Random random = new Random();
        int[,] array = new int[numRows, numCols];
        for (int row = 0; row < numRows; row++)
        {
            for (int col = 0; col < numCols; col++)
            {
                array[row, col] = random.Next(1, 100);
            }
        }
        return array;
    }

    static void SortRowsDescending(int[,] array)
    {
        int numRows = array.GetLength(0);
        int numCols = array.GetLength(1);
        for (int row = 0; row < numRows; row++)
        {
            for (int col = 0; col < numCols - 1; col++)
            {
                for (int k = 0; k < numCols - col - 1; k++)
                {
                    if (array[row, k] < array[row, k + 1])
                    {
                        int temp = array[row, k];
                        array[row, k] = array[row, k + 1];
                        array[row, k + 1] = temp;
                    }
                }
            }
        }
    }

    static void PrintArray(int[,] array)
    {
        int numRows = array.GetLength(0);
        int numCols = array.GetLength(1);

        for (int row = 0; row < numRows; row++)
        {
            for (int col = 0; col < numCols; col++)
            {
                Console.Write(array[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}
