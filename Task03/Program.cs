// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите число от 1 до 7"); // выводит в терминал текст
string a = Console.ReadLine(); // записывает в number число введенное пользователем в терминал и переводит в init32
if (a == "1")
{
    Console.WriteLine("понедельник");
}
else if (a == "2")
{
    Console.WriteLine("вторник");
}
else if (a == "3")
{
    Console.WriteLine("среда");
}
else if (a == "4")
{
    Console.WriteLine("четверг");
}
else if (a == "5")
{
    Console.WriteLine("пятница");
}
else if (a == "6")
{
    Console.WriteLine("суббота");
}
else if (a == "7")
{
    Console.WriteLine("воскресенье");
}
else
{
    Console.WriteLine("Введены неправильные данные");
}