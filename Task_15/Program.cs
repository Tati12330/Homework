// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
//6 -> да

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <1 || number > 7)
{
    Console.WriteLine("Такого дня недели не существует");
}
if (number == 6 || number == 7)
{
    Console.WriteLine("Да");
}
if (number >=1 & number < 6)
{
    Console.WriteLine("Нет");
}