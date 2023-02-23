// Напишите программу, 
// которая будет принимать на вход число и возвращать сумму его цифр.

// 453 -> 12

// 45 -> 9

using System;
using static System.Console;

Clear();
Write("Введите число: ");
int number = int.Parse(ReadLine());
WriteLine(SumNumber(number));

int SumNumber(int number)
{
    if (number == 0)
    {
        return 0;
    }
    return (number % 10 + SumNumber(number / 10));
}