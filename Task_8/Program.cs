//  Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int count = 2;
if (N > 0)
{
    while (count <= N)
    {

        Console.WriteLine(count + " ");
        count += 2;
    }
}

else
{
    Console.WriteLine("Введите положительное число");
}