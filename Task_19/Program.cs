//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < -9999)
{
    number = - number;
}

string numberStr = Convert.ToString(number);

if (numberStr.Length == 5)
{
  if (numberStr[0] == numberStr[4] & numberStr[1]== numberStr[3])
  {
    Console.WriteLine("Да, это палиндром.");
  }
  else
  {
    Console.WriteLine("Нет, это не палиндром.");
  }
}
else
{
    Console.WriteLine("Это не пятизначное число. Повторите ввод.");
}