Console.Clear();
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
if (num1 % num2 == 0)
{
    Console.WriteLine("Кратно");
}
else
{    
    Console.WriteLine($"Не кратно, остаток {num1 % num2}");
}