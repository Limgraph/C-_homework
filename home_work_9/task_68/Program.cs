// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.Clear();

int ack(int M, int N)
{
    if (M == 0)
        return N + 1;
    else if (N == 0)
        return ack(M - 1, 1);
    else
        return ack(M - 1, ack(M, N - 1));

}
Console.WriteLine("Введите первое число интервала: ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число интервала: ");
int N = int.Parse(Console.ReadLine()!);
int functionAck = ack(M, N);
Console.WriteLine(functionAck);