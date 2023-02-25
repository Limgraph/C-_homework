// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
Console.Clear();

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

int[,] FillArray(int[,] inArray, int size)
{
    int countNum = 1;
    for (int delta = 0; delta < size / 2 + 1; delta++)
    {
        for (int i = 0 + delta; i < size - delta; i++)
        {
            inArray[0 + delta, i] = countNum;
            countNum++;
        }
        countNum--;
        for (int j = 0 + delta; j < size - delta; j++)
        {
            inArray[j, size - 1 - delta] = countNum;
            countNum++;
        }
        countNum--;
        for (int k = size - 1 - delta; k >= 0 + delta; k--)
        {
            inArray[size - 1 - delta, k] = countNum;
            countNum++;
        }
        countNum--;
        for (int l = size - 1 - delta; l >= 1 + delta; l--)
        {
            inArray[l, 0 + delta] = countNum;
            countNum++;
        }
    }

    return inArray;
}

// Console.WriteLine("Введите количество цифр в стороне массива: ");
int size = 7; //int.Parse(Console.ReadLine());
int[,] array2D = new int[size, size];
int[,] fillArray = FillArray(array2D, size);
PrintArray(fillArray);