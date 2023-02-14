// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] CreateArray(int horiz, int vert, int min, int max)
{
    int[,] array = new int[horiz, vert];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],5},");
            else Console.Write($" {array[i, j],5}  ");
        }
        Console.WriteLine("]");
    }
}

int[,] result(int[,] firstArray, int[,] secondArray)
{
    int[,] multArray = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
    {
        for (int i = 0; i < firstArray.GetLength(0); i++)
        {
            for (int j = 0; j < secondArray.GetLength(1); j++)
            {
                for (int n = 0; n < firstArray.GetLength(1); n++)
                {
                    multArray[i, j] += firstArray[i, n] * secondArray[n ,1];
                }
            }  
        }
    }
    return multArray;
}

int[,] array1 = CreateArray(3, 2, 1, 4);
PrintArray(array1);
Console.WriteLine("Массив №1");

int[,] array2 = CreateArray(4, 2, 3, 5);
PrintArray(array2);
Console.WriteLine("Массив №2");

int[,] multArray = result(array1, array2);
PrintArray(multArray);
Console.WriteLine("Результат");
