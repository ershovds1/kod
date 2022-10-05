//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int a, result;

Console.WriteLine("Введите трехзначное число");
int.TryParse(Console.ReadLine()!, out a);
a = ((a / 10) % 10);

Console.WriteLine($"Вторая цифра {a}");