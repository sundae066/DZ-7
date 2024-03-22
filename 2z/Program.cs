﻿// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int Acr(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Acr(m - 1, 1);
    if (m > 0 && n > 0) return Acr(m - 1, Acr(m, n - 1));
    return 0;
}
Console.Write("Введите первое число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите первое число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write(Acr(m, n));
