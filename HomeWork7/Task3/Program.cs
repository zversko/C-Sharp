// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int InputNumber(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}


void PrintMatrix(double[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            Console.Write($"{matrix[rows, columns]}\t");
        }
        Console.WriteLine();
    }
}

void RandomMatrix(double[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            matrix[rows, columns] = new Random().Next(0, 10);
        }
    }
}

double[] AverageColumns(double[,] matrix)
{
    double[] a = new double[matrix.GetLength(1)];
    for (int columns = 0; columns < matrix.GetLength(1); columns++)
    {
        double sum = 0;
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            sum += matrix[rows, columns];
        }
        a[columns] = Math.Round (sum / matrix.GetLength(0) , 3);
    }
    return a;
}

void PrintArray(double[] a)
{
    int count = a.Length;
    int i = 0;
    Console.WriteLine("Среднее значение по столбцам:");
    while (i < count)
    {
        Console.Write($"{a[i]}\t");
        i++;
    }
}


void Main()
{
    int rows = InputNumber("Укажите количество строк - ");
    int columns = InputNumber("Укажите количество столбцов - ");
    double[,] matrix = new double[rows, columns];
    RandomMatrix(matrix);
    PrintMatrix(matrix);
    Console.WriteLine();
    double[] array = AverageColumns(matrix);
    PrintArray(array);
}

Main();