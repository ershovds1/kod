//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int a;

Console.WriteLine("Введите число");
int.TryParse(Console.ReadLine()!, out a);
int count = a.ToString().Length;
if (count >= 3)
{
    Console.WriteLine($"Третья цифра {a % 10}");
}
else
    Console.WriteLine("Третьей цифры нет");