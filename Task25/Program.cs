﻿/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243
2, 4 -> 16
*/

Console.Write("Введите число - ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень, в которую следует возвести число - ");
int st = Convert.ToInt32(Console.ReadLine());
int result = 1;

for (int i = 1; i <= st; i++)
{
    result = result * num;
}
Console.WriteLine($"Число {num} в степени {st} равняется {result}.");