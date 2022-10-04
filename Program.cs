//Программа, которая на вход принимает число и выдаёт, является ли число чётным
int a;
Console.WriteLine("Введите число");
a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
{
    Console.WriteLine("Четное число");
}
else
{
    Console.WriteLine("Нечетное число");
}