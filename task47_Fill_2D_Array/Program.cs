﻿/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Тестовый кейс: m = 3, n = 4 : {0,5 7 -2 -0,2}, {1 -3,3 8 -9,9}, {8 7,8 -7,1 9}

*/
Console.Clear ();

Console.WriteLine (" --- Заполнение двумерного массива случайными числами ---");

int GetNumber(string msg)
{
    int result = 0;

    while(true)
    {
        Console.Write(msg);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Введено не число. Повторите ввод.");
        }
    }
    return result;
}

int row = GetNumber ("Введите число строк в двумерном массиве: ");
int column = GetNumber ("Введите число столбцов в двумерном массиве: ");
int left = GetNumber ("Введите нижнюю границу случайных значений элементов массива: ");
int rigth = GetNumber ("Введите верхнюю границу случайных значений элементов массива: ");

double[ , ] InitArray(int line, int bar, int low, int high)
{
    double[ , ] arr = new double [line, bar];

    Random rnd = new Random();

    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < bar; j++)
        {
        arr[i,j] =(rnd.NextDouble() + rnd.Next (low, high+1));
        }
    }

    return arr;
}

void PrintArray(double[ , ] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
       for (int j=0; j < array.GetLength (1); j++)
        {
          Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    
}
double [ , ] RandomArray = InitArray(row, column, left, rigth);
PrintArray (RandomArray);