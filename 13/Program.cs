Console.Clear();
Console.Write("Введите xA: ");
double xA = double.Parse(Console.ReadLine());
Console.Write("Введите yA: ");
double yA = double.Parse(Console.ReadLine());
Console.Write("Введите xB: ");
double xB = double.Parse(Console.ReadLine());
Console.Write("Введите yB: ");
double yB = double.Parse(Console.ReadLine());
double l = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2));
Console.WriteLine($"Расстояние между точками равно: {l:f2}");