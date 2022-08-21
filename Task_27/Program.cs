// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);

int sum = 0;
int digit;

while (number > 0)
{
digit = number % 10;
sum = sum + digit;
number = number / 10;
}
Console.WriteLine($"Сумма цифр в числе равна {sum}");