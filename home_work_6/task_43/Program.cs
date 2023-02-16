// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();

Console.WriteLine("Введите число К1: ");
double k1 = 5;//double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B1: ");
double b1 = 2;//double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число K2: ");
double k2 = 9;//double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B2: ");
double b2 = 4;//double.Parse(Console.ReadLine()!);

double x, y1, y2, step;
//= k1*x +b1;
//= k2*x +b2;


double GetDot(double k1, double b1, double k2, double b2)
{
    x = 0.1;
    do
    {
        x -= 0.1;
        y1 = k1 * x + b1;
        y2 = k2 * x + b2;
    }
    while (y1 != y2);
    Console.WriteLine(y1);
    return x;
}

double getX = GetDot(k1, b1, k2, b2);
Console.WriteLine(getX);

