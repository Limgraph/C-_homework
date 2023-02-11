// Написать программу вычисления произведения чисел от 1 до N

Console.Clear();

Console.WriteLine("Введите до какого числа вычислить произведение чисел: ");
int num = int.Parse(Console.ReadLine()!);
int count = 1, multiply = 1;
while(count <= num)
{
    multiply = multiply * count;
    count++;
}

Console.WriteLine($"произведение чисел от 1 до {num} равна: {multiply}!");