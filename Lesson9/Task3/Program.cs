// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. Использовать рекурсию.
// 453 -> 12
// 45 -> 9

int InputNumber(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int SumDigit(int number)
{
    if (number <= 0)
    {
        return 0;
    }
    return SumDigit(number/10) + number % 10;
}

int number = InputNumber ("Ведите число > ");
int sum = SumDigit(number);
System.Console.WriteLine(sum);