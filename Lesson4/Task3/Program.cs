// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int number(string message)
{
    Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

void Mult()
{
    int arg = number("Введите число - ");
    double P = 1;
    if (arg > 0)
    {
        for (int i = 1; i <= arg; i++)
        {
            P = P * i;
        }
    }
    else
    {
        for (int i = -1; arg <= i; i--)
        {
            P = P * i;
        }
    }
    Console.WriteLine($"Произведение чисел от 1 до числа N {P}");
}

Mult();