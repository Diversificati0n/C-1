// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 0)
{
    TableSquare(number);
}
else System.Console.WriteLine("Не натуральное число");

void TableSquare(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count}\t" + Math.Pow(count, 2));
        count++;
    }
}

        // Console.WriteLine($"{count,4} {Math.Pow(count, 2),4}");
        // count++;