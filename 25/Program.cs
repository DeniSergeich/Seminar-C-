Console.Clear();
int[] array = GetRandomArray(10,0,10);
Console.WriteLine($"Array: {String.Join(' ', array)}");
Console.WriteLine($"Copy Array: {String.Join(' ', copyArray(array))}");
int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}
int[] copyArray(int[]array){
    int[] copyArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copyArray[i] = array[i];
    }
    return copyArray;
}