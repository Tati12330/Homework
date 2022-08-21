//Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран. Вводим массив через консоль

int [] array = new int [8];
Console.WriteLine("Введите восемь чисел через enter: ");

for (int i = 0; i < array.Length; i ++)
{
 array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Массив из введенных вами чисел: ");
Console.WriteLine(string.Join(", ", array));