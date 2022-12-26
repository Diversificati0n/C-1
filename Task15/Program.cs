// Задача 15: Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введи цифру от 1 до 7 (день недели): ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
void CheckingDay (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("выходной день");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("такого дня недели нет");
  }
  else Console.WriteLine("это не выходной день");
}
CheckingDay(dayNumber);
