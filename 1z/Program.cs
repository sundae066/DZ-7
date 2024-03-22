﻿// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.
string GetListNums(int M, int N, int index = 0)
{
    index = M;
    if(index == N) 
    {
        return Convert.ToString(index);
    }
    return index + " " + GetListNums(M + 1, N, index + 1);
}

Console.Write("Введите начальное число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetListNums(M, N));
