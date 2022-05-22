/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

void FillArray(int[] col)
{
    int length = col.Length;
    int index = 0;
    Console.WriteLine("Введите диапазон элементов массива:");
    Console.Write("От: ");
    int Min = Convert.ToInt32(Console.ReadLine());
    Console.Write("До: ");
    int Max = Convert.ToInt32(Console.ReadLine());
    if (Min < Max)
    {
        while (index < length)
        {
            col[index] = new Random().Next(Min, Max);
            index++;
        }
    }
    else
    {
        Console.WriteLine("Диапазон элементов массива указан некорректно!");
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    Console.Write("[");
    while (position < count)
    {
        Console.Write($"{col[position]},");
        position++;
    }
    Console.Write("]");
}

Console.Write("Введите число - количество элементов массива - ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
Console.WriteLine($"Составлен массив из {length} элементов.");

FillArray(array);
PrintArray(array);
Console.WriteLine();
