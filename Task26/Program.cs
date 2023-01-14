// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int countNumber = CountNumber(number);
Console.WriteLine($"Количество цифр в числе = {countNumber}");

int CountNumber(int digit)
{
    int count = 0;

    while (digit != 0)
    {
        digit = digit / 10;
        count = count + 1;
    }
    return count;
}
