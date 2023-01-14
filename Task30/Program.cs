// int[] array = new int[8]; // 0,1,2,3,4,5,6,7

// array[0] = 235;
// array[1] = 33;
// array[2] = 56;
// array[3] = -35;
// System.Console.WriteLine(array[2]);

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = 2;
// }

// int[] array1 = new int[5] { 2, 5, 7, 9, 0 };
// int[] array2 = new int[] { 2, 5, 7, 9, 0 };
// int[] array3 = { 2, 5, 7, 9, 0 };
// int[] array4 = new [] { 2, 5, 7, 9, 0 };

// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] array = new int[8]; // 0,1,2,3,4,5,6,7
// FillArray(array);
// PrintArray(array);

// void FillArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(0, 2);
//     }
// }

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + " ");
//     }
// }


int[] array = new int[8]; // 0,1,2,3,4,5,6,7
FillArray(array);
PrintArray(array);

void FillArray(int[] arr)
{
    Random rnd = new Random(); // !!!!!!!!!!!!!!!!!!!!!!!!!!!!
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 2); // !!!!!!!!!!!!!!!!!!!!!!!!!!!!
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}