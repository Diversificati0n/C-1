// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


int[] array = CreateArrayRndInt(5, -10 ,10);
PrintArray(array);
int[] newArr = MultiplyElemetn(array);
PrintArray(newArr);

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-20, 10);
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

int[] MultiplyElemetn(int[] arr)
{
    int size = arr.Length / 2;
    if (arr.Length % 2 == 1 /*!=0*/) size += 1;
    int[] newArr = new int[size];
    for (int i = 0; i < size; i++)
    {
        if (i != arr.Length - 1 - i)
            newArr[i] = arr[i] * arr[arr.Length - 1 - i];
        else newArr[i] = arr[i];
    }
    return newArr;
}