// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

class MatrixMultiplication
{
    static void Main()
    {
        int rowsA = 2;
        int colsA = 2;
        int rowsB = 2;
        int colsB = 2;
        Random random = new Random();
        int[,] matrixA = new int[rowsA, colsA];
        int[,] matrixB = new int[rowsB, colsB];
        Console.WriteLine("Матрица A:");
        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsA; j++)
            {
                matrixA[i, j] = random.Next(1, 10);
                Console.Write(matrixA[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nМатрица B:");
        for (int i = 0; i < rowsB; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                matrixB[i, j] = random.Next(1, 10);
                Console.Write(matrixB[i, j] + " ");
            }
            Console.WriteLine();
        }
        if (colsA != rowsB)
        {
            Console.WriteLine("Умножение матриц невозможно. Количество столбцов матрицы A не равно количеству строк матрицы B.");
        }
        else
        {
            int[,] resultMatrix = new int[rowsA, colsB];
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    resultMatrix[i, j] = 0;
                    for (int k = 0; k < colsA; k++)
                    {
                        resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }
            Console.WriteLine("\nРезультирующая матрица:");
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    Console.Write(resultMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        Console.ReadLine();
    }
}