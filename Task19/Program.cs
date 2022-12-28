// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 10000 & number <= 99999)
{
    Console.WriteLine($"{number} ");
    Console.WriteLine(Palindrome(number) ? "да" : "нет");
}
else
{
    Console.WriteLine("неверное число");
}

bool Palindrome(int number1)
{
    if (number / 10000 == number % 10 & number / 1000 % 10 == number / 10 % 10)
        return true;
    else return false;
}