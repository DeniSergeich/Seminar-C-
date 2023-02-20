// Сделать частотный словарь для двумерного массива


using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int m = int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int n = int.Parse(ReadLine());

int[,] array = FillArray(m, n, 0, 9);
PrintArray(array);
int[] minMax = MinMax(array);
int[] oneDemensoinalArray = OneDemensoinalArray(array);
WriteLine();
PrintResult(oneDemensoinalArray, minMax);
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

int[] MinMax(int[,] array)
{
    int[] minMax = new int[2];
    int min = 0;
    int max = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min) min = array[i, j];
            if (array[i, j] > max) max = array[i, j];
            
        }
        minMax[0] = min;
        minMax[1] = max;
    }
    return minMax;
}

int[] OneDemensoinalArray(int[,] array)
{
    int[] oneDemensoinalArray = new int[array.GetLength(0)*array.GetLength(1)];
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            oneDemensoinalArray[index] = array[i,j];
            index++;
        }
    }
    return oneDemensoinalArray;
}

void PrintResult(int[] oneDemensoinalArray, int[] minMax)
{
    int min = minMax[0];
    int max = minMax[1];
    
    for (int i = min; i <= max; i++)
    {
        int count = 0;        
        for (int j = 0; j < oneDemensoinalArray.Length; j++)
        {
            if(oneDemensoinalArray[j] == i) count++;            
        }       
        if(count != 0) WriteLine($"{i} встречается {count} раз");
    }

}