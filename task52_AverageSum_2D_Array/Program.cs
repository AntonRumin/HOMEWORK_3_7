/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*
Console.Clear ();

Console.WriteLine (" --- Среднее арифметическое элементов массива ---");

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

int [ , ] InitArray(int line, int bar, int low, int high)
{
    int[ , ] arr = new int [line, bar];

    Random rnd = new Random();

    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < bar; j++)
        {
        arr[i,j] =rnd.Next (low, high+1);
        }
    }
    return arr;
}

void PrintArray(int[ , ] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
       for (int j=0; j < array.GetLength (1); j++)
        {
          Console.Write(array[i,j] + "  ");
        }
        Console.WriteLine();
    }
    
}
Console.Clear ();

Console.WriteLine (" --- Среднее арифметическое элементов массива ---");

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

int [ , ] InitArray(int line, int bar, int low, int high)
{
    int[ , ] arr = new int [line, bar];

    Random rnd = new Random();

    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < bar; j++)
        {
        arr[i,j] =rnd.Next (low, high+1);
        }
    }
    return arr;
}

void PrintArray(int[ , ] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
       for (int j=0; j < array.GetLength (1); j++)
        {
          Console.Write(array[i,j] + "  ");
        }
        Console.WriteLine();
    }
    
}
*/
Console.Clear ();

Console.WriteLine (" --- Среднее арифметическое элементов массива ---");

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

int [ , ] InitArray(int line, int bar, int low, int high)
{
    int[ , ] arr = new int [line, bar];

    Random rnd = new Random();

    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < bar; j++)
        {
        arr[i,j] =rnd.Next (low, high+1);
        }
    }
    return arr;
}

void PrintArray(int[ , ] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
       for (int j=0; j < array.GetLength (1); j++)
        {
          Console.Write(array[i,j] + "  ");
        }
        Console.WriteLine();
    }
    
}
// Вспомогательная часть. Создание и заполнение массива

int row = GetNumber("Введите число строк массива: ");
int column = GetNumber("Введите число столбцов массива:");
int left = GetNumber ("Введите нижнюю границу случайных значений элементов массива: ");
int rigth = 0;

while (true)
{
rigth = GetNumber ("Введите верхнюю границу случайных значений элементов массива: ");

    if (left < rigth) break;
    else Console.WriteLine("Верхняя граница значений не может быть меньше или равна нижней границе. Повторите ввод");
}


Console.Write("Введите признак для расчета среднего арифметического числа (1 - по столбцам, 2 - по строкам): "); 
int manager = int.Parse(Console.ReadLine());

int [ , ] randomArray = InitArray(row, column, left, rigth);
PrintArray (randomArray);
switch(manager)
{
    case 1:
    
    Console.WriteLine();
    for (int j = 0; j < column; j++)
    {
        double averageColumn = 0;

            for (int i = 0; i < row; i++)
            {
                averageColumn += randomArray [i,j];
            }
        Console.WriteLine ($"Среднее арифметическое значение столбца {j+1} равно: {averageColumn/row}");
    }
    break;
case 2:
    
    Console.WriteLine();
    for (int i = 0; i < row; i++)
    {
        double averageRow = 0;
        
            for (int j = 0; j < column; j++)
            {
                averageRow += randomArray [i,j];
            }
        Console.WriteLine ($"Среднее арифметическое значение строки {i+1} равно: {averageRow/column}");
    }
    break;
}