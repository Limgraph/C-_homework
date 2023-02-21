// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

double[,] GetArray(int m, int n, double minValue, double maxValue)
{
    double[,] result = new double[m,n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = Math.Round(new Random().NextDouble()*(maxValue - minValue) + minValue, 2);
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
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

Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int col = int.Parse(Console.ReadLine()!);

double[,] array2D = GetArray(row, col, 1, 10);
PrintArray(array2D);