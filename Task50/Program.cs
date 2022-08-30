﻿// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение этого элемента
//  или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 10)
{
    int[,]matrix = new int[rowsCount, columnsCount];
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
int[,]matrix = FillMatrix(3,4);
PrintMatrix(matrix);
Console.WriteLine("Введите индекс нужной строки m и индекс столбца n через Enter ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
void ShowIndexMatrix(int[,]matrix)
{
    if (m >= 0 && m < matrix.GetLength(0) && n >= 0 && n < matrix.GetLength(1))
    {
       Console.WriteLine($"В этой ячейке находится число {matrix[m,n]}");
    }
    else 
    {
    
         Console.WriteLine("Такого числа в массиве нет.");
    }
}
ShowIndexMatrix(matrix);