// Задача 3.
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int number(string message)
{
    Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

void Pow()
{
    int arg = number("Введите число - ");
    double P = 0;
    if (arg > 0)
    {
        for (int i = 0; i <= arg; i++)
        {
            P = Math.Pow(i, 3);
            Console.WriteLine($"{P}");
        }
    }
    else
    {
        for (int i = 0; arg <= i; i--)
        {
            P = Math.Pow(i, 3);
            Console.WriteLine($"{P}");
        }
    }
}

Pow();