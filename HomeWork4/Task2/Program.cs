// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Promt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int Sum()
{
    int number = Promt("Введите число > 0 ");
    int count = 0;
    int sum = 0;
    int ost = 0;
    while (number > 0)
    {
        ost = number % 10;
        sum = sum + ost;
        number = number / 10;
        count++;
    }
    return sum;
}

void PrintNumbers(int value)
{
    Console.WriteLine($"Сумма цифр в числе = {value}");
}

PrintNumbers(Sum());