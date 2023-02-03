//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();

Console.Write("Введите первое число: ");
int number_1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int number_2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите третье число: ");
int number_3 = int.Parse(Console.ReadLine()!);

int max = 0;

if(number_1 > number_2)
{
    max = number_1;
}
else 
{
    max = number_2;
}

if(number_3 > max)
{
    Console.WriteLine($"Из трёх чисел большее: {number_3}");
}
else
{
    Console.WriteLine($"Из трёх чисел большее: {max}");
}