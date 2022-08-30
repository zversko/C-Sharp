// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


int InputNumber(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}


void PrintMatrix(int[,] matrix)
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

void RandomMatrix(int[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            matrix[rows, columns] = new Random().Next(0, 10);
        }
    }
}

void ChangeRowColumn(int[,] matrix)
{   
    int[] a = new int[matrix.GetLength(1)];
    int LastColumns = matrix.GetLength(0) - 1;
    for (int columns = 0; columns < matrix.GetLength(0); columns++)
    {
        a[columns] = matrix[0, columns];
        matrix[0, columns] = matrix[LastColumns, columns];
        matrix[LastColumns, columns] = a[columns];
    }
}

void Main()
{
    int rows = InputNumber("Укажите количество строк - ");
    int columns = InputNumber("Укажите количество столбцов - ");
    int[,] matrix = new int[rows, columns];
    RandomMatrix(matrix);
    PrintMatrix(matrix);
    ChangeRowColumn(matrix);
    Console.WriteLine();    

    PrintMatrix(matrix);
    
    Console.WriteLine();
}

Main();