// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


Console.Clear();

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