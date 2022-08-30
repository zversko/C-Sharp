// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void RandomMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 4);
        }
    }
}

void MatrixMultiplication(int[,] matrix1, int[,] matrix2, int[,] matrixMult)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrixMult[i, j] = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
                matrixMult[i, j] += matrix1[i, k] * matrix2[k, j];
        }
    }
}

void Main()
{
    System.Console.WriteLine("Укажите размеры первой матрицы");
    int rows1 = InputNumber("Количество строк - ");
    int columns1 = InputNumber("Количество столбцов - ");
    int[,] matrix1 = new int[rows1, columns1];

    System.Console.WriteLine("Укажите размеры второй матрицы");
    int rows2 = InputNumber("Количество строк - ");
    int columns2 = InputNumber("Количество столбцов - ");
    int[,] matrix2 = new int[rows2, columns2];

    int[,] matrixMult = new int[rows1, columns2];

    if (columns1 == rows2)
    {
        RandomMatrix(matrix1);
        PrintMatrix(matrix1);
        Console.WriteLine();
        RandomMatrix(matrix2);
        PrintMatrix(matrix2);
        Console.WriteLine();
        MatrixMultiplication(matrix1, matrix2, matrixMult);
        PrintMatrix(matrixMult);
    }
    else
    {
        System.Console.WriteLine("Такие матрицы умножить невозможно");
    }
}

Main();