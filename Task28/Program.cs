// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


// Console.WriteLine("Введите целое число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{number} -> {SumNumbers(number)}");

// int SumNumbers(int num)
// {
//     int sum = 1;
//     for (int i = 1; i <= num; i++)
//     {
//         sum *= i;
//     }
//     return sum;
// }


Console.Write ("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

// if number <= 0

int factorialNumber = FactorialNumber(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {factorialNumber}");

int FactorialNumber(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
        result *= i;
        }
    }
    return result;
}