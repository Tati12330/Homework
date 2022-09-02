// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
//* Результирующая матрица будет:
// 18 20
// 15 18

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
Console.WriteLine("Введите количество строк m и количество столбцов n через Enter ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Матрица №1:");
int[,] matrix1 = FillMatrix(m, n);
PrintMatrix(matrix1);
Console.WriteLine();
Console.WriteLine("Матрица №2:");
int[,] matrix2 = FillMatrix(m, n);
PrintMatrix(matrix2);
Console.WriteLine();
int[,]compositionMatrix = new int[m,n];

for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            compositionMatrix[i,j] = matrix1[i,j] * matrix2[i,j];
        }
    }
Console.WriteLine("Результирующая матрица в результате умножения двух мариц:");
PrintMatrix(compositionMatrix);