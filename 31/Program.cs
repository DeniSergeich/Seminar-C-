// Замена строк массива на столбцы (строка переходит в столбец в новом массиве)

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int m = int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int n = int.Parse(ReadLine());


int[,] array = FillArray(m, n, 0, 9);
PrintArray(array);
int[,] resultArray = GetArray(array);
WriteLine();
PrintArray(resultArray);

int[,] FillArray(int m, int n, int minValue, int maxValue)
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

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}

int[,] GetArray(int[,] array)
{
    int[,] resultArray = new int[array.GetLength(1), array.GetLength(0)];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            resultArray[j,i] = array[i,j];
        }
    }
    return resultArray;
}