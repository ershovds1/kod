//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int a;

Console.WriteLine("Введите число от 1 до 7: ");
//a = Convert.ToInt32(Console.ReadLine());
int.TryParse(Console.ReadLine()!, out a);
if (a == 6)
{
    Console.WriteLine("Выходной");
}
else if (a == 7)
{
    Console.WriteLine("Выходной");
}
else
    Console.WriteLine("Рабочий день");