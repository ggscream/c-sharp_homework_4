﻿// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

double Exponentiation(double a, int b) => Math.Pow(a, b);

Console.WriteLine("Введите число А: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число B (Строго положительное): ");
int b = Convert.ToInt32(Console.ReadLine());

double c = Exponentiation(a, b);
Console.WriteLine(c);
