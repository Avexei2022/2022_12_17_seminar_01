//Console.Write("Введите число: ");
//int number = Convert.ToInt32(Console.ReadLine());
//int number = int.Parse(Console.ReadLine());
//int sqr = number * number;
//Console.WriteLine("Квадрат числа " + number + " равен: " + sqr);
//Console.WriteLine($"Квадрат числа {number} равен: {sqr}");

//Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да 
//a = 2, b = 10 -> нет 
//a = 9, b = -3 -> да 
//a = -3 b = 9 -> нет


Console.Write("Введите первое число: ");
int numFirst = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numSecond = Convert.ToInt32(Console.ReadLine());

if (numFirst == numSecond*numSecond)
    Console.Write($"Число {numFirst} является квадратом {numSecond}");
else 
    Console.Write($"Число {numFirst} не является квадратом {numSecond}");

// https://docs.google.com/presentation/d/1VQ_wIbogkQqiLNMjkrE1sZpOUNVCVdvnsxL3uX9RB1k/edit#slide=id.g1347c153eec_0_320

