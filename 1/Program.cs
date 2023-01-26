Console.Clear();
Console.Write("Введите первое число: ");
int numberOne = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberTwo = int.Parse(Console.ReadLine());
if (numberTwo*numberTwo == numberOne){
    Console.WriteLine($"Число {numberOne} является квадратом {numberTwo}");
}
else {
    Console.WriteLine($"Число {numberOne} не является квадратом {numberTwo}");
}