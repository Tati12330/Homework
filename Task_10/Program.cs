﻿//Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
//456 -> 5

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 & number < 1000)
{
    Console.WriteLine((number % 100) / 10);
}
else
{
    Console.WriteLine("Это не трехзначное число.");
}