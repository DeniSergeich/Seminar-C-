Console.Clear();
Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
if (number > 999 || number < -999)
{
    Console.WriteLine("Вы ввели некоректное число");
    return;
}
else if (number > 0)
{
    Console.WriteLine(number % 10);
}
else if (number < 0)
{
    Console.WriteLine(number % 10 * -1);
}