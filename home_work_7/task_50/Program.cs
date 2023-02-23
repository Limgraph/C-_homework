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

int[] GetCoord(int pozition)
{
    int[] arr = new int[2];
    arr[0] = pozition / 10;
    arr[1] = pozition % 10;
    return arr;
}

void SearchElement(int[] coord, int[,] mass)
{
    if (coord[0] < mass.GetLength(0) && coord[1] < mass.GetLength(1))
        Console.WriteLine($"{mass[coord[0], coord[1]]}");
        else Console.WriteLine("Такого числа не существует!");
}

int row = 4;
int col = 4;

int[,] array2D = GetArray(row, col, 1, 10);
PrintArray(array2D);

Console.WriteLine("Введите позицию элемента: ");
int pozition = int.Parse(Console.ReadLine()!);

int[] poz = GetCoord(pozition);
SearchElement(poz, array2D);