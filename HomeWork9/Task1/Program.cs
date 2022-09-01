// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int InputNumber(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

void ShowNaturalRow(int min, int max)
{
    if (max < min || max < 2)
    {
        Console.WriteLine("The End");
        return;
    }

    ShowNaturalRow(min, max - 2);
    System.Console.WriteLine(max);
}

void Main()
{
    int N = InputNumber("Введите первое число > ");
    int M = InputNumber("Введите второе число > ");
    if (N < M && M % 2 == 0) ShowNaturalRow(N, M);
    if (N < M && M % 2 != 0) ShowNaturalRow(N, M - 1);
    if (M < N && N % 2 == 0) ShowNaturalRow(M, N);
    if (M < N && N % 2 != 0) ShowNaturalRow(M, N - 1);
}

Main();