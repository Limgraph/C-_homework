// Подсчитать сумму цифр в числе
Console. Clear();

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int sum = 0, last_num, variable = num;

while(variable > 0)
{
    last_num = variable % 10;
    sum += last_num;
    variable = variable / 10;
}

Console.WriteLine($"Сумма цифр в заданном числе {num} равна: {sum}");