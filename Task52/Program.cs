// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int matrixRows = 3;
int matrixColumns = 3;
int matMinValue = 0;
int matrixMaxValue = 5;
int[,] matrix = CreateMatrix(matrixRows, matrixColumns, matMinValue, matrixMaxValue);
PrintMatrix(matrix);

int[,] CreateMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToInt32(rnd.Next(minValue, maxValue));
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


for (int i = 0; i < matrixColumns; i++)
{
    double arithmeticMean = 0;
    for (int j = 0; j < matrixRows; j++)
    {
        arithmeticMean += matrix[j, i];
    }
    arithmeticMean = Math.Round(arithmeticMean / matrixRows, 1);
    Console.WriteLine($"{arithmeticMean}");
}


