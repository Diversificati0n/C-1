// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine("Введите натуральное неотрицательное число m: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное неотрицательное число n: ");
int number1 = Convert.ToInt32(Console.ReadLine());

int functionAkkerman = Ackkman(number, number1);

int Ackkman(int number, int number1)
{
  if (number == 0) return number1 + 1;
  else if (number1 == 0) return Ackkman(number - 1, 1);
  else return Ackkman(number - 1, Ackkman(number, number1 - 1));
}

