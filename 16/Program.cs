Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int GetNum(int number)
{
    int count = 0;
    if (number < 0)
    {
        number *= -1;
    }
    while (number > 0)
    {
        number /= 10;
        count++;
    }
    return count;
}
Console.WriteLine($"Количество цифр в числе: {GetNum(number)}");