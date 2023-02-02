Console.Clear();
Console.Write("Введите номер четверти координат: ");
int number = int.Parse(Console.ReadLine());
if (number < 1 || number > 4)
{
    Console.WriteLine("Введите число от 1 до 4!");
    return;
}
if (number == 1)
{
    Console.WriteLine("Диапазон координат: (X;Y)");
}
if (number == 2)
{
    Console.WriteLine("Диапазон координат: (-X;Y)");
}
if (number == 3)
{
    Console.WriteLine("Диапазон координат: (-X;-Y)");
}
if (number == 4)
{
    Console.WriteLine("Диапазон координат: (X;-Y)");
}