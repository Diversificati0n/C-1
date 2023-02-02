// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

int matrixRows = 5;
int matrixColumns = 5;
int matrixMinValue = 1;
int matrixMaxValue = 10;

int[,] firstMatrix = CreateMatrix(matrixRows, matrixColumns, matrixMinValue, matrixMaxValue);
PrintMatrix(firstMatrix);
Console.WriteLine(String.Empty);

int[] firstArray = NumberDictionary(firstMatrix);
PrintArray(firstArray);
Console.WriteLine(String.Empty);
Array.Sort(firstArray);
PrintArray(firstArray);
Console.WriteLine(String.Empty);
Dictionary(firstArray);

int[,] CreateMatrix(int rows, int columns, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[,] matrix = new int[rows, columns];
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
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine($"]", 4);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

int[] NumberDictionary(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[index] = matrix[i, j];
            index++;
        }
    }
    return array;
}

void Dictionary(int[] array)
{
    int number = array[0];
    int count = 1;

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == number) count++;
        else
        {
            Console.WriteLine($"{number} -> {count}");
            number = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"{number} -> {count}");
}



/*
int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
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

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int[] MatrixToArray(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = matrix[i, j];
            k++;
        }
    }
    return array;
}

int[,] UniqElemQantity(int[] arr)
{
    int count = 0;
    int[] uniqNum = arr.Distinct().ToArray();
    int[,] arr2D = new int[uniqNum.Length, 1];
    int currentElement = arr[0];
    int k = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (currentElement == arr[i + 1])
            count++;
        else
        {
            arr2D[k, 0] = currentElement;
            arr2D[k, 1] = count;
            k++;
        }
    }
    return arr2D;
}


int[,] array2D = CreateMatrix(4, 4, 0, 10);
PrintMatrix(array2D);
Console.WriteLine();

int[] array = MatrixToArray(array2D);
PrintArray(array);
Console.WriteLine();
Array.Sort(array);
PrintArray(array);*/
