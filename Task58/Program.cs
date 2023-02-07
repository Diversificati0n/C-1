// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int matrixRows = 2;
int matrixColumns = 2;
int matMinValue = 0;
int matrixMaxValue = 10;
int[,] matrix = CreateMatrix(matrixRows, matrixColumns, matMinValue, matrixMaxValue);
PrintMatrix(matrix);

int[,] matrix1 = CreateMatrix(matrixRows, matrixColumns, matMinValue, matrixMaxValue);
Console.WriteLine(" ");
PrintMatrix(matrix1);

int[,] resMatrix = new int[matrixRows,matrixColumns];

MultiplicationMatrix(matrix, matrix1, resMatrix);
Console.WriteLine("Результирующая матрица:");
PrintMatrix(resMatrix);

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

void MultiplicationMatrix(int[,] matrix, int[,] matrix1, int[,] resMatrix)
{
    for (int i = 0; i < resMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int t = 0; t < matrix.GetLength(1); t++)
            {
                sum += matrix[i, t] * matrix1[t, j];
            }
            resMatrix[i, j] = sum;
        }
    }
}
