// Перевод из десятичной системы в 2...16

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
string res = DecToNumber(number, 3);
Console.WriteLine($"{number} -> {res}");

string DecToNumber(int decNumber, int otherSystem)
{
    string res = "";
    string nums = "0123456789abcdef";
    while(decNumber>0){
        int ost = decNumber/otherSystem;
        res = nums[decNumber-otherSystem*ost]+res;
        decNumber/= otherSystem;
    }
    return res;
}