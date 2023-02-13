Console.Clear();
Console.Write("Введите первую сторону: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите вторую сторону: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите третью сторону: ");
int c = int.Parse(Console.ReadLine());
if (IsTriangle(a, b, c))
{
    Console.WriteLine("Может!");
}
else
{
    Console.WriteLine("Не может!");
}
bool IsTriangle(int a, int b, int c)
{
    return a + b > c && a + c > b && c + b > a;
}