//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = { 3, 7, 22, 2, 78 };
double min = array[0];
double max = array[0];
double result = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }
    if (array[i] > max)
    {
        max = array[i];
    }
}
result = max - min;
Console.WriteLine($"Разница между max и min элементами массива {result}");