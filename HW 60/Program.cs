// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

class Program
{
    static void Main()
    {
        int[,,] array3D = GenerateRandom3DArray(2, 2, 2);
        Print3DArrayWithIndices(array3D);
    }
    static int[,,] GenerateRandom3DArray(int xSize, int ySize, int zSize)
    {
        int[,,] array = new int[xSize, ySize, zSize];
        Random rand = new Random();
        for (int x = 0; x < xSize; x++)
        {
            for (int y = 0; y < ySize; y++)
            {
                for (int z = 0; z < zSize; z++)
                {
                    int randomNum;
                    do
                    {
                        randomNum = rand.Next(10, 100);
                    } while (IsNumberInArray(array, randomNum));
                    array[x, y, z] = randomNum;
                }
            }
        }
        return array;
    }
    static bool IsNumberInArray(int[,,] array, int number)
    {
        foreach (int element in array)
        {
            if (element == number)
            {
                return true;
            }
        }
        return false;
    }

    static void Print3DArrayWithIndices(int[,,] array)
    {
        int xSize = array.GetLength(0);
        int ySize = array.GetLength(1);
        int zSize = array.GetLength(2);
        for (int x = 0; x < xSize; x++)
        {
            for (int y = 0; y < ySize; y++)
            {
                for (int z = 0; z < zSize; z++)
                {
                    Console.Write($"{array[x, y, z]}({x},{y},{z}) ");
                }
                Console.WriteLine();
            }
        }
    }
}