// Задача №7. Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8

// Напишите программу, которая на вход принимает одно число (N),
//  а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.Clear();
int number = 0;
Console.Write("Введите целое трехзначное число: ");
int.TryParse(Console.ReadLine(), out number);

while (number < 100 | number > 999)
{
    Console.WriteLine("Условия ввода не выполнены.");
    Console.Write("Повторите ввод числа: ");
    int.TryParse(Console.ReadLine(), out number);
}

Console.WriteLine($"{number} -> {number % 10}");
Console.WriteLine("");