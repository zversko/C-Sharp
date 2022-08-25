// Задайте двумерный массив. Найдите сумму элементов главной диагонали.
// Например, задан массив:
// 1   4   7
// 5   9   2
// 8   4   2
// Сумма элементов главной диагонали: 1+9+2 = 12


int number(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

void PrintArray(int[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            Console.Write($"{matrix[rows, columns]} ");
        }
        Console.WriteLine();
    }
}

void RandomArray(int[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            matrix[rows, columns] = new Random().Next(0, 10);
        }
    }
}

int DiagonalSum(int[,] matrix)
{   
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}

void Main()
{
    int rows = number("Укажите количество строк");
    int columns = number("Укажите количество столбцов");
    int[,] matrix = new int[rows, columns];
    PrintArray(matrix);
    Console.WriteLine();
    RandomArray(matrix);
    PrintArray(matrix);
    Console.WriteLine();
    int Sum = DiagonalSum(matrix);
    Console.WriteLine(Sum);
}

Main();