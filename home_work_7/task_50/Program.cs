// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");//'\t' - табуляция; \n перенос на следующую строку; Escape последовательность, управляющая последовательность
        }
        Console.WriteLine();
    }
}

int GetElement(int[,] array)
{
    Console.WriteLine("Введите позицию элемента: ");
    int pozition = int.Parse(Console.ReadLine()!);
    int[] arr = new int[2];
    if (pozition < 100 && pozition > 0)
    {
        arr[0] = pozition / 10;
        arr[1] = pozition % 10;
        pozition = array[arr[0], arr[1]];
    }
    else
    {
        Console.WriteLine("Такого элемента не существует!");
    }

    return pozition;
}

Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int col = int.Parse(Console.ReadLine()!);

int[,] array2D = GetArray(row, col, 1, 10);
PrintArray(array2D);
int poz = GetElement(array2D);
Console.WriteLine(poz);