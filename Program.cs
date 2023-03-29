// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.WriteLine("\nЗадача 1.");
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

double[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

// ----------------Заполнение массива
double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] res = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = Math.Round(new Random().NextDouble() * (maxValue - minValue) + minValue, 1);
        }
    }
    return res;
}

// -----------------Вывод массива-----------------
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Задача 50. Напишите программу, которая на вход принимает два числа(строка, столбец), проверяя есть ли такая позиция в двумерном массиве и возвращает сообщение о том, что оно найдено, а также какое число стоит на этом месте или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// i = 1, j = 3 -> Такой элемент есть: 3
// i = 4, j = 2 -> такого элемента в массиве нет

bool CheckElement(double[,] array, int r, int c)
{
    bool fl = true;
    if (r >= array.GetLength(0))
    {
        Console.WriteLine("Нет такой строки в массиве.");
        fl = false;
    }
    if (c >= array.GetLength(1))
    {
        Console.WriteLine("Нет такого столбца в массиве.");
        fl = false;
    }
    return fl;
}

Console.WriteLine("\nЗадача 2.");
Console.Write("Введите строку (индекс строки): ");
rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите столбец (индекс столбца): ");
columns = int.Parse(Console.ReadLine()!);

if (CheckElement(array, rows, columns)) Console.WriteLine($"Такой элемент есть в массиве: {array[rows, columns]}");


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void AverageColumn(double[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double summ = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            summ += array[j, i];
        }
        Console.WriteLine($"Среднее арифмитическое {i}-го столбца: {Math.Round(summ/array.GetLength(0),1)}");
    }
}

Console.WriteLine("\nЗадача 3.");
PrintArray(array);
Console.WriteLine("");
AverageColumn(array);