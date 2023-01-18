// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// Console.Write("Введите целое число ");
// var number = int.Parse(Console.ReadLine());

// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     var rnd = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     Console.Write('[');
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
//         else Console.Write(arr[i]);
//     }
//     Console.Write("]");
// }

// bool YesNo(int num, int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (num == arr[i]) return true;
//     }
//     return false;
// }

// int[] array = CreateArrayRndInt(12, -9, 9);
// PrintArray(array);

// Console.WriteLine(YesNo(number, array) == true ? " -> Да" : " -> Нет");

int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);

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

bool GetNumInArray(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num)
            return true;
    }
    return false;
}

Console.Write("Введите число, которое нужно найти в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
bool getNumInArray = GetNumInArray(array, number);
if (getNumInArray)
{
    Console.Write($"Число {number} есть в массиве - ");
    PrintArray(array);
}
else
{
    Console.Write($"Числа {number} нет в массиве - ");
    PrintArray(array);
}