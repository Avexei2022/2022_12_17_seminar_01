// Задача №3. Напишите программу, которая будет выдавать
//  название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.Clear();
int number_day = 0;
Console.Write("Введите номер дня недели: ");
int.TryParse(Console.ReadLine(), out number_day);

while (number_day < 1 | number_day > 7)
{
    Console.WriteLine("Такого дня недели не существует.");
    Console.Write("Повторите ввод дня недели: ");
    int.TryParse(Console.ReadLine(), out number_day);
}

if (number_day == 1)
{
    Console.WriteLine($"{number_day} - Понедельник");
}
if (number_day == 2)
{
    Console.WriteLine($"{number_day}- Вторник");
}
if (number_day == 3)
{
    Console.WriteLine($"{number_day} - Среда");
}
if (number_day == 4)
{
    Console.WriteLine($"{number_day} - Четверг");
}
if (number_day == 5)
{
    Console.WriteLine($"{number_day} - Пятница");
}
if (number_day == 6)
{
    Console.WriteLine($"{number_day} - Суббота");
}
if (number_day == 7)
{
    Console.WriteLine($"{number_day} - Воскресенье");
}
Console.WriteLine("");