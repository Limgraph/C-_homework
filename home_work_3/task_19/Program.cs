// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();

int palindrome;
do
{
    Console.Clear();
    Console.WriteLine("Введите пятизначное число: ");
    palindrome = int.Parse(Console.ReadLine()!);
}
while (palindrome >= 100000 || palindrome <= 9999);

int variable = palindrome;
int reverse = 0;
while (variable > 0)
{
    int remainder = variable % 10;
    reverse = (reverse * 10) + remainder;
    variable = variable / 10;
}
if (palindrome == reverse)
{
    Console.WriteLine($"Число {palindrome} является палиндромом!");
}
else
{
    Console.WriteLine($"Число {palindrome} не является палиндромом!");
}