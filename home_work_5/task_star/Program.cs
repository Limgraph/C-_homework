// Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сторировку.
// [3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
// [1,2,2,3,2] -> [3, 2, 2, 2, 1]
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

void MakeOrder(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int index_of_max = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[index_of_max])
            {
                index_of_max = j;
            }
        }
        int temporary = array[i];
        array[i] = array[index_of_max];
        array[index_of_max] = temporary;
    }
}

int[] array = GetArray(7, -10, 10);
Console.WriteLine(String.Join(", ", array));
MakeOrder(array);
Console.WriteLine(String.Join(", ", array));
