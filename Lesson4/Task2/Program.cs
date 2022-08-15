// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// Console.WriteLine("Введите натуральное число");
// int NatNum = int.Parse(Console.ReadLine());
// int digitCount = (int)Math.Log10(NatNum) + 1;
// Console.WriteLine(digitCount);

int Promt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void main()
{
    int number = Promt("Введите число > 0 ");
    int count = 0;
    while (number > 0)
    {
        number = number / 10;
        count++;
    }
    Console.WriteLine($"Количество цифр в числе {number} - {count}");
}

main();