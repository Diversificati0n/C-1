// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//  что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("Введи число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
string number1Text = Convert.ToString(number1);
if (number1Text.Length > 2){
  Console.WriteLine("третья цифра" + number1Text[2]);
}
else {
  Console.WriteLine("третьей цифры нет");
}