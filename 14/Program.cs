Console.Clear();
Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine());
for(int i = 1; i <= x; i++){    
    Console.Write($"{Math.Pow(i, 2)} ");
}
