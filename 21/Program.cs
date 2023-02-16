Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int[] array = GetRandomArray(8, -10, 10);
Console.WriteLine(String.Join(" ", array));
int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}
string Res(int[] array, int n)
{
    string resultSTR = "";
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == n)
        {
            resultSTR = "Yes";
            return resultSTR;            
        }
        else
        {
            resultSTR = "No";
        }
    }
    return resultSTR;
}
Console.WriteLine(Res(array, n));