﻿// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int m = InputInt("Введите значение m: ");
int n = InputInt("Введите значение n: ");
Console.WriteLine($"Сумма натуральных элементов от {m} до {n} = {CountNaturalSum(m, n)}");
int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
int CountNaturalSum(int m, int n)
{
    if (m == n)
        return n;
    return n + CountNaturalSum(m, n - 1);
}
