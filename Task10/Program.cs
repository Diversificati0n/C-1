// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. Выполнить с помощью 
// числовых операций (целочисленное деление, остаток от деления).
// 456 -> 5
// 782 -> 8
// 918 -> 1



// Console.Write("Введите трёхзначное число: ");
// int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
// string strNumber = Convert.ToString(threeDigitNumber);
// Console.WriteLine("вторая цифра этого числа -> "+strNumber[1]); 

Console.WriteLine("Введите трёхзначное число: ");
string str = Convert.ToString(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("Вторая цифра: {0}", (str.Length > 1) ? str.Substring(str.Length - 2, 1) : " ");
