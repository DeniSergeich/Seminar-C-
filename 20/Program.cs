Console.Clear();
int[] array = GetRandomArray(8, -10, 10);
Console.WriteLine($"Изначально: {String.Join(" ", array)}");
Console.WriteLine($"После преобразования: {String.Join(" ", InverseArray(array))}");
int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}
int[] InverseArray(int[] array)
{ 
     
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}
