// Со звездочкой (*) Напишите программу, которая заполнит спирально квадратный массив.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int InputNumber(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}");
        }
        Console.WriteLine();
    }
}

void RandomMatrix(int[,] matrix)
{
    int N = matrix.GetLength(0);
    for (int mark1 = 1, mark0 = 0; mark0 < N / 2; mark0++)
    {
        for (int j = mark0; j < N - mark0; j++)
            matrix[mark0, j] = mark1;
        for (int j = mark0; j < N - mark0; j++)
            matrix[N - mark0 - 1, j] = mark1;
        for (int i = mark0 + 2; i < N - mark0 - 1; i++)
            matrix[i, mark0] = mark1;
        for (int i = mark0 + 1; i < N - mark0 - 1; i++)
            matrix[i, N - mark0 - 1] = mark1;
        mark1 = 1 - mark1;
        matrix[mark0 + 1, mark0] = mark1;
    }
}

void Main()
{
    int rows = InputNumber("Укажите размер квадратной матрицы - ");
    int columns = rows;
    int[,] matrix = new int[rows, columns];
    Console.WriteLine();
    RandomMatrix(matrix);
    PrintMatrix(matrix);
    Console.WriteLine();
}
Main();