//Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку
//  с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange = 1, int rightRange = 10)
{
    int[,] matrix = new int[rowsCount, columnsCount];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк m и количество столбцов n через Enter: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[] arrayOfSums = new int[m];
Console.WriteLine();
int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine();

for (int i = 0; i < matrix.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum += matrix[i, j];
    }
    arrayOfSums[i] = sum;
    Console.WriteLine($"Сумма {i + 1} строки = {sum}");
}
//Console.WriteLine(string.Join(", ", arrayOfSums));
int minSum = arrayOfSums[0];
int minLine = 0;
for (int i = 0; i < arrayOfSums.Length; i++)
{
    if (arrayOfSums[i] <= minSum)
    {
        minSum = arrayOfSums[i];
        minLine = i + 1;
    }
}
Console.WriteLine($"Строка с минимальной суммой элементов: {minLine}");