// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers(number);
Console.WriteLine("Сумма цифр в числе: " + sumNumbers);

if(number >= 0)
{
    Console.WriteLine();
}
else
{
    Console.WriteLine("Ошибка! Введите положительное число");
}

int SumNumbers(int number)
{
int counter = Convert.ToString(number).Length;
int movement = 0;
int result = 0;

for (int i = 0; i < counter; i++)
    {
        movement = number - number % 10;
        result = result + (number - movement);
        number = number / 10;
    }
        return result;
}
