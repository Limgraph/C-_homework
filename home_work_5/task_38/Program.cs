// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.Clear();

double[] GetArray(int size, int minValue, int maxValue)
{
    double[] result = new double[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = Math.Round(new Random().NextDouble() + new Random().Next(minValue, maxValue + 1), 2);
    }
    return result;
}

double GetDiff(double[] array)
{
    double max = array[0], min = array[0], diff;
    foreach (double element in array)
    {
        if(element > max)
        {
            max = element;
        }
        if(element < min)
        {
            min = element;
        }
    }
    // Console.WriteLine(max);
    // Console.WriteLine(min);
    diff = Math.Round((max - min), 2);//иногда выдаёт результат с количеством цифр больше 2 после запятой
    return diff;
}

double[] array = GetArray(5, -100, 100);
Console.WriteLine(String.Join(" | ", array));

double difference = GetDiff(array);
Console.WriteLine(difference);//в остальном вроде работает