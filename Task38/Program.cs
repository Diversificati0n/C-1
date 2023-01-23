// Задача 38: Задайте массив вещественных чисел.
//  Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2



double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    var rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + "| ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

double MaxArray(double[] arr)
{
    double maxArray = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < maxArray)
            maxArray = arr[i];
    }
    return maxArray;
}

double MinArray(double[] arr)
{
    double minArray = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > minArray)
            minArray = arr[i];
    }
    return minArray;
}


double[] array = CreateArrayRndDouble(5, -100, 100);
PrintArrayDouble(array);

double maxArray = MaxArray(array);
Console.WriteLine();
double minArray = MinArray(array);
Console.WriteLine();

Console.WriteLine($"Разницу между максимальным и минимальным элементом массива { Math.Round(maxArray - minArray, 1)}");
