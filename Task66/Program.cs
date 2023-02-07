// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите натуральное число M: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int number1 = Convert.ToInt32(Console.ReadLine());

int t = number;

if (number > number1)
{
    number = number1;
    number1 = t;
}

PrintSum(number, number1, t = 0);

void PrintSum(int number, int number1, int sum)
{
    sum = sum + number1;
    if (number1 <= number)
    {
        Console.Write($"Сумма элементов равна {sum}");
        return;
    }
    PrintSum(number, number1 - 1, sum);
}