// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"

Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number>0)
{
NumbersN(number);
}
else
{
Console.WriteLine("Введите значение N больше 0");
}
void NumbersN(int n)
{
    if (n < 1) return;
    Console.Write(n + " ");
    NumbersN(n - 1);
}