﻿//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

if (B > 0)
{
int degree = A;
int i;

for (i = 1;  i < B; i++)
{
    degree = A * degree;
}

Console.WriteLine($"A в степени B: {degree}");
}
else
{
Console.WriteLine("Введено некорректное значение B. Повторите, пожалуйста попытку");
}