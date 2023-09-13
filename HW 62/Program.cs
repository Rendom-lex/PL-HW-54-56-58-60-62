// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

class Program
{
    static void Main()
    {
        int n = 4;
        int[,] matrix = new int[n, n];
        int top = 0, bottom = n - 1, left = 0, right = n - 1;
        int counter = 1;
        while (counter <= n * n)
        {
            for (int i = left; i <= right; i++)
            {
                matrix[top, i] = counter;
                counter++;
            }
            top++;
            for (int i = top; i <= bottom; i++)
            {
                matrix[i, right] = counter;
                counter++;
            }
            right--;

            for (int i = right; i >= left; i--)
            {
                matrix[bottom, i] = counter;
                counter++;
            }
            bottom--;
            for (int i = bottom; i >= top; i--)
            {
                matrix[i, left] = counter;
                counter++;
            }
            left++;
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{matrix[i, j]:D2} ");
            }
            Console.WriteLine();
        }
    }
}
