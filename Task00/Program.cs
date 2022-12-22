// Напишите программу, которая 
// 1. на вход принимает число (формулировка значит что данные вводит пользователь) и 
// 2. выдаёт его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49
Console.WriteLine("Введите целое число");
//string str = Console.ReadLine(); 134864966
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}"); // $ - интерполяция {переменные} 
