// Задача 10: Напишите программу, которая 
// 1. принимает на вход трёхзначное число и 
// 2. на выходе показывает вторую цифру этого числа.
// 3.  Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 456 -> 5
// 782 -> 8
// 918 -> 1



// Console.Write("Введите трёхзначное число: ");
// int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
// string strNumber = Convert.ToString(threeDigitNumber);
// Console.WriteLine("вторая цифра этого числа -> "+strNumber[1]); 

// Console.WriteLine("Введите трёхзначное число: ");
// string str = Convert.ToString(Convert.ToInt32(Console.ReadLine()));
// Console.WriteLine("Вторая цифра: {0}", (str.Length > 1) ? str.Substring(str.Length - 2, 1) : " ");

Console.WriteLine("Введите трехзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
int n = threeDigitNumber / 10 % 10;
Console.WriteLine($"Второе число {n}");

if (threeDigitNumber > - 99 || - 1000 > threeDigitNumber)
if (threeDigitNumber < 99 || 1000 < threeDigitNumber)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}


