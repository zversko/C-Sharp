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
    for (int i = 0; i < b; i++)
    {
        MP = MP * a;
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
    double MP = MathPow(num1, num2);
    PrintNumbers(num1, num2, MP);
}

Main();