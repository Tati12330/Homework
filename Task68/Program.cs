// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

Console.WriteLine("Введите неотрицательные значения M и N через Enter: ");
int numberM = Convert.ToInt32(Console.ReadLine());
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < 0 && numberN < 0)
{
    Console.WriteLine("Введите положительные значения.");
}
else
{
    int sum = FunctionOfAccerman(numberM, numberN);
    Console.WriteLine(sum);
}

int FunctionOfAccerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return FunctionOfAccerman(m - 1, 1);
    }
    else
    {
        return FunctionOfAccerman(m - 1, FunctionOfAccerman(m, n - 1));
    }
}