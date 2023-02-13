//Задача 54: Задайте двумерный массив. Напишите программу,
//которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("Введите первое значение ");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первое значение ");
int numberN = Convert.ToInt32(Console.ReadLine());

int[,] array = newArraw[m, n];
InitArray(array);
WriteArray(array);

void ArrayM(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            if (array[i,k] < array[i, k+1])
        }
        {
                int temp = array[i, k+1];
                array[i, k+1] = array[i, k];
                array[i, k] = temp;
        }
    }
}
}

int Numbers(string input)
{
    Console.Write(input);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
