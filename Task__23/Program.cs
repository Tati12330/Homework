// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27 

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Таблица кубов чисел от 1 до N:");
if (N > 0)
{
    for (int i = 1; i <= N; i++)
    {
        Console.WriteLine(Math.Pow(i, 3) + " ");
    }
}
else
{
    Console.WriteLine("Введите, пожалуйста, положительное число с новой попыткой.");
}