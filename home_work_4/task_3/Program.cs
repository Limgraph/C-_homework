// Показать кубы чисел, заканчивающихся на четную цифру
Console.Clear();

Console.WriteLine("Введите до какого числа показать кубы чисел, заканчивающихся на четную цифру: ");
int num = int.Parse(Console.ReadLine()!);

double count = 1, cubed;

while (count <= num)
{
    cubed = Math.Pow(count, 3);

    if (cubed % 2 == 0)
    {
        Console.WriteLine($"Куб числа {count} = {cubed} и является чётным.");
    }
    count++;
}