//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int number = vvod("Введите число: ");
int len = Num(number);
Sum(number, len);

// Ввод
int vvod(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Подсчета цифр в числе
int Num(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

//Вывод суммы цифр в числе
void Sum(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sum);
}
