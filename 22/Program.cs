Console.Clear();
int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}
int[] array = GetRandomArray(10, 0, 10);
Console.WriteLine($"[{String.Join(", ", array)}]");

int[] ReverseArray(int[] array)
{
    int[] revArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        revArray[i] = array[array.Length - 1 - i];
    }
    return revArray;
}
Console.WriteLine($"[{String.Join(", ", ReverseArray(array))}]");