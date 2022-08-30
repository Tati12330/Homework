// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

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
void ArifmeticMatrix(int[,] matrix)
{
    double columnArifmetic = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            columnArifmetic = columnArifmetic + matrix[i, j];
        }
        columnArifmetic = columnArifmetic / matrix.GetLength(0);
        Console.WriteLine($"Среднее арифметическое столбца {j + 1} равно {columnArifmetic}");
        columnArifmetic = 0;
    }
}


Console.WriteLine("Введите количество строк m и количество столбцов n через Enter ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);
ArifmeticMatrix(matrix);