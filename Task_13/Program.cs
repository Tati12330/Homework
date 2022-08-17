//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры неn

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int digitIndex = 2;
if (number < 0)
{
    number = - number;
}
if (number > 99)
{
string numberStr = Convert.ToString(number);
if (numberStr.Length >= digitIndex)
{
    Console.WriteLine("Третья цифра в данном числе: " + numberStr[2]);
}
}
else
{
    Console.WriteLine("Третьей цифры нет.");
}