/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/
Console.Clear();

Console.WriteLine(" --- Поиск позиции и вывод значения заданного элемента в двумерном массиве");
// Объявление методов

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
rigth = GetNumber ("Введите верхнюю границу случайных значений элементов массива: "); // Проверка на правильность внесения интервала

    if (left < rigth) break;
    else Console.WriteLine("Верхняя граница значений не может быть меньше или равна нижней границе. Повторите ввод");
}

int [ , ] randomArray = InitArray(row, column, left, rigth); // Заполнение массива

PrintArray (randomArray); // Печать массива

// Основная часть

int positionRow = GetNumber ("Введите номер строки искомого элемента: ");

int positionColumn = GetNumber ("Введите номер столбца искомого элемента: ");

if (positionRow <= randomArray.GetLength(0) & positionColumn <= randomArray.GetLength (1))
{
int elementValue = 0;

 for (int i = 0; i < randomArray.GetLength(0); i++)
 {
    for (int j = 0; j < randomArray.GetLength(1); j++)

    if (i == (positionRow - 1) && j == (positionColumn - 1))
    {
        elementValue = randomArray[i,j];
        break;
    }
 }
 
 Console.WriteLine($"Элемент в строке {positionRow} и в столбце {positionColumn} имеет значение {elementValue}");
}
else 
{
Console.WriteLine ("Позиция искомого элемента выходит за рамки заданного массива.");
}
