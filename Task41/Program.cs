﻿// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

void FillArray (int[] arr)
{
    Console.WriteLine($"Введите числа для массива:");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());  
    }
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int PositiveNumbersCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0)
        {
            count++;
        }
    }
    return count;
}


Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
if (size < 1)
{
    Console.WriteLine("Размер не может быть <=0.");
}
int[] array = new int[size];

FillArray(array);
Console.WriteLine();
PrintArray(array);
int result = PositiveNumbersCount(array);
Console.WriteLine();
Console.WriteLine($"В массиве {result} чисел(-ла) больше 0.");