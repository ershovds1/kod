//Напишите программу, которая принимает на вход пятизначное число и 
//проверяет, является ли оно палиндромом;

Console.WriteLine("Введите пятизначное число");

string a = Console.ReadLine();
int len = a.Length;

if (len == 5)
{
    if (a[0] == a[4] && a[1] == a[3])
    {
        Console.WriteLine($"{a} - Число является палиндромом");
    }
    else
    {
        Console.WriteLine($"{a} - Число не является палиндромом");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {a} - не является пятизначным");
}

