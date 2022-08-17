// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27 

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine($"Таблица кубов чисел от 1 до {N}: ");
Console.WriteLine();
Console.WriteLine("Число\tКуб числа");
    
for (int i = 1; i <= N; i++)
{
    Console.WriteLine("{0}\t{1}", i, Math.Pow(i, 3));
}