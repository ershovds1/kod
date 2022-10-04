//Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел

int a, b, c;
Console.WriteLine("Введите три числа : ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Максимальное число");
Console.WriteLine(Math.Max(a, Math.Max(b, c)));