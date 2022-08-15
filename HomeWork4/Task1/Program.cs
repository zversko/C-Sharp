// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int number(string message)
{
    Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

double MathPow(int a, int b)
{
    double MP = 1;
    if (b == 0)
    {
        MP = 1;
    }
    else
    {
        if (b > 0)
        {
            for (int i = 0; i < b; i++)
            {
                MP = MP * a;
            }
        }
        else
        {
            for (int i = 0; b < i; i--)
            {
                MP = MP * a;
            }
            MP = 1 / MP;
        }

    }
    return MP;
}

void PrintNumbers(int a, int b, double p)
{
    Console.WriteLine($"Число {a} в степени {b} = {p}");
}

void Main()
{
    int num1 = number("Введите число, которое надо возвести в степень ");
    int num2 = number("Введите степень, в которую надо возвести число ");
    if (num1 == 0 && num2 < 0)
    {
        Console.WriteLine("На ноль делить нельзя");
    }
    else
    {
        double MP = MathPow(num1, num2);
        PrintNumbers(num1, num2, MP);
    }
}

Main();