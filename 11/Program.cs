Console.Clear();
Console.Write("Введите Х: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите Y: ");
int y = int.Parse(Console.ReadLine());
if (x > 0 && y > 0)
{
    Console.WriteLine("1");
}
if (x < 0 && y > 0)
{
    Console.WriteLine("2");
}
if (x < 0 && y < 0)
{
    Console.WriteLine("3");
}
if(x > 0 && y < 0){
    Console.WriteLine("4");
}
if(x == 0 || y == 0){
    Console.WriteLine("На оси");
}