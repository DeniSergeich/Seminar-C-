Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int MultNum(int number)
{
    int prod = 1;
    for (int i = 2; i <= number; i++)
    {
        prod *= i;
    }
    return prod;
}
Console.WriteLine($"Произведение чисел от 1 до {number}: {MultNum(number)}");