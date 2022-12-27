// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//  что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// Console.Write("Введи число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// string number1Text = Convert.ToString(number1);
// if (number1Text.Length > 2){
//   Console.WriteLine("третья цифра" + number1Text[2]);
// }
// else {
//   Console.WriteLine("третьей цифры нет");
// }


Console.Write("Введи число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

int ThirtDigit(int number2)
{
    if (number2 > 999 || number2 < -999)
    while (number2 > 999 || number2 < -999)
    {
      number2 = number2 / 10;
    }
    int answer = number2 % 10;
    return answer;
}

if (number1 <= 99 & number1 >= -99)
    Console.Write($"Третьей цифры нет");
else
{
    int res = ThirtDigit(number1);
    Console.WriteLine(res);
}
