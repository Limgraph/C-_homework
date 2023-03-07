// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Clear();

int GetSum(int M, int N)
{
    if (M == N) return N;
    else return M + GetSum(M + 1, N);
}
Console.WriteLine("Введите первое число интервала: ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число интервала: ");
int N = int.Parse(Console.ReadLine()!);

int intervalSum = GetSum(M, N);
Console.WriteLine(intervalSum);
