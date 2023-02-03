//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();

// Console.Write("Введите первое число: ");
// int number_1 = int.Parse(Console.ReadLine()!);

// Console.Write("Введите второе число: ");
// int number_2 = int.Parse(Console.ReadLine()!);

// if(number_1 > number_2)
// {
//     Console.WriteLine(number_1);
// }
// else
// {
//     Console.WriteLine($"Из двух чисел большее: {number_2}");
// }

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.Write("Введите первое число: ");
// int number_1 = int.Parse(Console.ReadLine()!);

// Console.Write("Введите второе число: ");
// int number_2 = int.Parse(Console.ReadLine()!);

// Console.Write("Введите третье число: ");
// int number_3 = int.Parse(Console.ReadLine()!);

// int max = 0;

// if(number_1 > number_2)
// {
//     max = number_1;
// }
// else 
// {
//     max = number_2;
// }

// if(number_3 > max)
// {
//     Console.WriteLine($"Из трёх чисел большее: {number_3}");
// }
// else
// {
//     Console.WriteLine($"Из трёх чисел большее: {max}");
// }

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.Write("Введите число для проверки на чётность: ");
// int x = int.Parse(Console.ReadLine()!);

// if(x%2 == 0)
// {
//     Console.WriteLine("Введённое число является чётным!");
// }
// else
// {
//     Console.WriteLine("Введённое число не является чётным!");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine()!);

int count = 1;

while(count < x)
{
    if(count%2 == 0)
    {
        Console.Write($"{count} ");
        count++;
    }
    else{
        count++;
    }
}