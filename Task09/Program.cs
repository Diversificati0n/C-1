﻿// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");

// int firstDigit = number / 10;
// int secondDigital = number % 10;
// if (firstDigit > secondDigital) Console.WriteLine($"Наибольшая цифра числа => {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа => {secondDigital}");



// int result = firstDigit > secondDigital ? firstDigit : secondDigital;
// Console.WriteLine($"Наибольшая цифра числа => {result}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа => {maxDigit}");

int maxDigit1 = MaxDigit(45);
Console.WriteLine($"Наибольшая цифра числа => {maxDigit1}");

int maxDigit2 = MaxDigit(78);
Console.WriteLine($"Наибольшая цифра числа => {maxDigit2}");

int MaxDigit(int num) // num = number
{
    int firstDigit = num / 10;
    int secondDigital = num % 10;
    int result = firstDigit > secondDigital ? firstDigit : secondDigital;
    return result;
}
