// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int GetEven(int[] array)
{
    int count_even = 0;
    foreach (var element in array)
    {
        if (element % 2 == 0)
        {
            count_even++;
        }
    }
    return count_even;
}

int[] array = GetArray(5, -100, 100);
Console.WriteLine(String.Join(", ", array));

int even = GetEven(array);
Console.WriteLine(even);