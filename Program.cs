//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

Console.Writeln("Введите координату x1: ");
int.TryParse(Console.ReadLine()!, out x1);

Console.Writeln("Введите координату y1: ");
int.TryParse(Console.ReadLine()!, out y1);

Console.Writeln("Введите координату x2: ");
int.TryParse(Console.ReadLine()!, out x2);

Console.Writeln("Введите координату y2: ");
int.TryParse(Console.ReadLine()!, out y2);

Console.Writeln("Введите координату z1: ");
int.TryParse(Console.ReadLine()!, out z1);

Console.Writeln("Введите координату z2: ");
int.TryParse(Console.ReadLine()!, out z2);

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длинна отрезка {length}");
