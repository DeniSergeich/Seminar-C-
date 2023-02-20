// Дан массив, поменять местами первую и последнюю строки

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int m = int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int n = int.Parse(ReadLine());

Write("Введите первую строку: ");
int a1 = int.Parse(ReadLine());

Write("Введите вторую строку: ");
int a2 = int.Parse(ReadLine());

int[,] array = FillArray(m, n, 0, 9);
PrintArray(array);
GetArray(array, a1, a2);
WriteLine();
PrintArray(array);

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
            Write($"{array[i,j]} ");
        }
        WriteLine();
    }
}

void GetArray(int[,] array, int a, int b)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int k = array[a-1, i];
        array[a-1,i] = array[b-1,i];
        array[b-1,i] = k;
    }
    
}