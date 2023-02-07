// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int matrixRows = 4;
int matrixColumns = 4;
int matMinValue = 0;
int matrixMaxValue = 10;
int[,] matrix = CreateMatrix(matrixRows, matrixColumns, matMinValue, matrixMaxValue);
PrintMatrix(matrix);

int minSumRows = 0;
int sumRows = SumRows(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
    int temp = SumRows(matrix, i);
    if (sumRows > temp)
    {
        sumRows = temp;
        minSumRows = i;
    }
}
Console.Write($"{minSumRows + 1} - строкa с наименьшей суммой элементов ");


int[,] CreateMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(minValue, maxValue);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},");
            else Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("]");
    }
}

int SumRows(int[,] matrix, int i)
{
    int sumRows = matrix[i, 0];
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        sumRows += matrix[i, j];
    }
    return sumRows;
}
