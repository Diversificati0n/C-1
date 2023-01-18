// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

bool GetNumInArray(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num)
            return true;
    }
    return false;
}

Console.Write("Введите число, которое хотите найти в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
bool getNumberInArray = GetNumInArray(array, number);
if (getNumberInArray)
{
    Console.Write($"Число {number} есть в массиве - ");
    PrintArray(array);
}
else
{
    Console.Write($"Числа {number} нет в массиве - ");
    PrintArray(array);
}