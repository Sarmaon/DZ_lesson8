//Задача 54: Задайте двумерный массив. Напишите программу,
//которая упорядочит по убыванию элементы каждой строки двумерного массива.

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
            if (j < array.GetLength(1) - 1) Console.Write($" {array[i, j],5},");
            else Console.Write($"{array[i, j],5}  ");
        }
        Console.WriteLine("]");
    }
}

int[,] HorizSortArray(int[,] arraySecond)
{
    int tempMax;

    for (int i = 0; i < arraySecond.GetLength(0); i++)
    {
        for (int j = 0; j < arraySecond.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < arraySecond.GetLength(1) - 1 - j; k++)
            {
                if (arraySecond[i, k] < arraySecond[i, k + 1])
                {
                    tempMax = arraySecond[i, k];
                    arraySecond[i, k] = arraySecond[i, k + 1];
                    arraySecond[i, k + 1] = tempMax;
                }
            }
        }
    }
    return arraySecond;
}


int[,] array = CreateArray(4, 5, -10, 10);
PrintArray(array);

Console.WriteLine("Отсортированно по убыванию ");

int[,] HorizSort = HorizSortArray(array);
PrintArray(HorizSort);

int Numbers(string input)
{
    Console.Write(input);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
