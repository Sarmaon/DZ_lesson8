//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int[,] MinSum(int[,] arraySecond)
{
    int[,] sumArraySecond = new int[arraySecond.GetLength(0), 1];
    for (int i = 0; i < arraySecond.GetLength(0); i++)
    {
        int horizSum = 0;
        for (int j = 0; j < arraySecond.GetLength(1); j++)
        {
            horizSum += arraySecond[i, j];
            sumArraySecond[i, 0] = horizSum;
        }
    }
return sumArraySecond;
}

void result(int[,] array)
{
    int arrayIndex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[arrayIndex, 0] >= array[i,0]) arrayIndex = i;
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов №{arrayIndex + 1}");
}

int[,] array = CreateArray(5, 5, -10, 10);
PrintArray(array);
Console.WriteLine("Сумма по строкам = ");

int[,] sumHoriz = MinSum(array);
PrintArray(sumHoriz);

result(sumHoriz);

    
