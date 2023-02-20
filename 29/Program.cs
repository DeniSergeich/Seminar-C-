using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int m = int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int n = int.Parse(ReadLine());

int[,] array = GetArray(m, n, 0, 10);
PrintArray(array);
WriteLine($"Сумма элементов по диагонали равна: {SumDiagonalElement(array)}");

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}

int SumDiagonalElement(int[,] array)
{
    int lenght = array.GetLength(0) < array.GetLength(1) ? array.GetLength(0) : array.GetLength(1);
    int sum = 0;
    for (int i = 0; i < lenght; i++)
    {
        sum += array[i, i];
    }    
    return sum;
}