//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double b1 = ReadInt("Введите b1: ");
double b2 = ReadInt("Введите b2: ");
double k1 = ReadInt("Введите k1: ");
double k2 = ReadInt("Введите k2: ");

double first = (b1 - b2) / (k2 - k1);
double second = (k2 * first) + b2;

Console.WriteLine($"({first}:{second})");

// Метод
double ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
