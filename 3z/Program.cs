﻿// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.
using System.Text;
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;
Console.Clear();
void EnumerationFromTheEnd(char[] arr, int index = 0)
{
    if (index == arr.Length - 1)
    {
        Console.Write($"{arr[index]} ");
        return;
    }
    EnumerationFromTheEnd(arr, index + 1);
    Console.Write($"{arr[index]} ");
}
Console.Write("Введите массив: ");
string st = Console.ReadLine()!;
char[] mas = st.ToCharArray();
EnumerationFromTheEnd(mas);