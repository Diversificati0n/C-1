// Задача 29: Напишите программу, которая задаёт массив из 
//8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int [] array = CreateArray(8);
PrintArray(array);

int [] CreateArray(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 100);
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

// int[] array = new int[8];
// Console.Write("[ ");

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 100);
//     Console.Write(array1(i) + ", ");
// }
// Console.Write("]");

// int array1(int a)
// {
//     return array[a];
// }

