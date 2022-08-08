//Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
//Например, a = 5; b = 7 -> max = 7

Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{

    Console.WriteLine("max = " + numberA);
    Console.WriteLine("min = " + numberB);
}

if (numberB > numberA)
{
    Console.WriteLine("max = " + numberB);
    Console.WriteLine("min = " + numberA);
}

if (numberB == numberA)
{
    Console.WriteLine("Данные числа равны");
}