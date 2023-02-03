//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();

Console.Write("Введите первое число: ");
int number_1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int number_2 = int.Parse(Console.ReadLine()!);

if(number_1 > number_2)
{
    Console.WriteLine(number_1);
}
else
{
    Console.WriteLine($"Из двух чисел большее: {number_2}");
}
