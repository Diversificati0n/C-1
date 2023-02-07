// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет



int matrixRows = 5;
int matrixColumns = 5;
int matMinValue = -10;
int matrixMaxValue = 10;
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

Console.WriteLine("индекс строки элемента");
int rowsSearch = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("индекс столбца элемента");
int columnsSearch = Convert.ToInt32(Console.ReadLine());

if (rowsSearch >= matrixRows && columnsSearch >= matrixColumns)
    Console.WriteLine("элемента с таким индексом нет");
else
{
    object element = matrix.GetValue(rowsSearch, columnsSearch);
    Console.WriteLine($"{element}");
}