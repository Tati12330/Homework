// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
Console.WriteLine("Введите число M и N через Enter, где M < N: ");
int numberM = Convert.ToInt32(Console.ReadLine());
int numberN = Convert.ToInt32(Console.ReadLine());
if (numberM > numberN)
{
    Console.WriteLine("Введите значение M, которое меньше N");
}
else
{
    int sum = SumNToM(numberN,numberM);
    Console.WriteLine(sum);
}

int SumNToM(int n,int m)
{
    if (n < m) return 0;
    int sum = SumNToM(n - 1, m);
    return sum = sum + n;
}