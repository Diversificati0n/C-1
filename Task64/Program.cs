// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите натуральное число N: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 2;
PrintNumber(number, count);
Console.Write(1);

void PrintNumber(int number, int count)
{
  if (count > number) return;
  PrintNumber(number, count + 1);
  Console.Write($"{count}, ");
}
