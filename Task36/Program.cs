// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    var rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

int[] array = CreateArrayRndInt(4, -5, 5);
PrintArray(array);

int SumOdd(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i+=2)
    sum += arr[i];
    return sum;
}

int sumOdd = SumOdd(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях {sumOdd}");
