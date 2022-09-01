// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int InputNumber(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int SumNaturalNum(int min, int max)
{
    if (max < min || max < 1)
    {
        return 0;
    }

    return SumNaturalNum(min, max - 1) + max;
}

void Main()
{
    int N = InputNumber("Введите первое число > ");
    int M = InputNumber("Введите второе число > ");
    if (N < M) 
    {
        int sum = SumNaturalNum(N, M);
        System.Console.WriteLine(sum);
    }
    else
    {
        int sum = SumNaturalNum(M, N);
        System.Console.WriteLine(sum);
    }
}


Main();