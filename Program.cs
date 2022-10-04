//программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
int a, i;
i = 1;
Console.WriteLine("Введите число : ");
a = Convert.ToInt32(Console.ReadLine());
if (i == 1)
{
    i += 1;
}

Console.WriteLine("Все четные числа");
while (i <= a)
{
    Console.WriteLine(i);
    i += 2;
}


