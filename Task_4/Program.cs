//Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.
//Например, 2, 3, 7 -> 7
Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if (numberB > max)
{
    max = numberB;
}

if (numberC > max)
{
    max = numberC;
}

Console.WriteLine("max = " + max);