/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243
2, 4 -> 16
*/

Console.Write("Введите число - ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень, в котору следует возвести число - ");
int st = Convert.ToInt32(Console.ReadLine());
int result = 1;
int i = 1;

// Не понял что не так, но через For работает некорректно, сделал через While.
// Исходные данные одинаковые.
/*
for (int i = 1; i <= st; i++)
{
    result = result * num;
    i++;
}
*/

while (i <= st)
{
    result = result * num;
    i++;
}

Console.WriteLine($"Число {num} в степени {st} равняется {result}.");