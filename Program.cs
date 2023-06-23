// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Введите число сторок массива");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число столбцов массива");
// int colums = Convert.ToInt32(Console.ReadLine());

// double[,] numbers = new double[rows, colums];
// FillArray(numbers);
// PrintArray(numbers);

// void FillArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(-99, 99) / 10.0;
//         }
//     }
// }

// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }



//  Задача 50. Напишите программу, которая на вход принимает позиции элемента 
//  в двумерном массиве, и возвращает 
//  значение этого элемента или же указание, что такого элемента нет.
//  Во вводе первая цифра - номер строки, вторая - столбца. Цифры не больше 9.
//  Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  17 -> такого числа в массиве нет


Console.WriteLine("Введите число сторок массива");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число столбцов массива");
int colums = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[rows, colums];

Console.WriteLine("Введите индекс стороки");
int rows1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите индекс столбца");
int colums1 = Convert.ToInt32(Console.ReadLine());
FillArray(numbers);
PrintArray(numbers);

if (rows1 < numbers.GetLength(0) && colums1 < numbers.GetLength(1)) Console.WriteLine(numbers[rows1, colums1]);
else Console.WriteLine($"{rows1} {colums1} -> такого числа в массиве нет");

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}




