// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

using static System.Console;

WriteLine("Введите целое число: ");
int c = Convert.ToInt32(ReadLine());

int sum = 0;

while (c != 0)
{
    sum += (c % 10);
    c /= 10;
}

WriteLine(sum);