// Напишите программу, которая на вход принимает одно число (N),
//  а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.Clear();
int number = 0;
Console.Write("Введите целое положительное число от 1 до 20: ");
int.TryParse(Console.ReadLine(), out number);

while (number < 1 | number > 20)
{
    Console.WriteLine("Условия ввода не выполнены.");
    Console.Write("Повторите ввод числа: ");
    int.TryParse(Console.ReadLine(), out number);
}

Console.Write($"{number} -> ");
int count = number * -1;
while (count < number)
{
    Console.Write($"{count}, ");
    count++;
}
Console.WriteLine($"{count}."); // Точка
