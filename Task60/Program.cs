// *Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int matrixRows = 2;
int matrixColumns = 2;
int matrixDepth = 2;
int matMinValue = 10;
int matrixMaxValue = 99;
int[,,] matrix = CreateMatrix3D(matrixRows, matrixColumns, matrixDepth, matMinValue, matrixMaxValue);
PrintMatrix(matrix);

int[,,] CreateMatrix3D(int rows, int columns, int depth, int minValue, int maxValue)
{
    int[,,] matrix = new int[rows, columns, depth];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = rnd.Next(minValue, maxValue);
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (k < matrix.GetLength(2) - 1) Console.Write($"{matrix[i, j, k]},");
                else Console.Write($"{matrix[i, j, k]} ");
            }
        }
        Console.WriteLine("]");
    }
}

