// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.


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

void TransporationMatrix(int[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {

        for (int columns = rows; columns < matrix.GetLength(1); columns++)
        {
            int temp = matrix[rows, columns];
            matrix[rows, columns] = matrix[columns, rows];
            matrix[columns, rows] = temp;
        }
    }
}

void Main()
{
    int rows = InputNumber("Укажите количество строк - ");
    int columns = InputNumber("Укажите количество столбцов - ");
    if (rows == columns && rows > 0 && columns > 0)
    {
        int[,] matrix = new int[rows, columns];
        RandomMatrix(matrix);
        PrintMatrix(matrix);
        TransporationMatrix(matrix);
        Console.WriteLine();
        PrintMatrix(matrix);
        Console.WriteLine();
    }
    else
    {
        System.Console.WriteLine("Матрица не квадратная");
    }

}

Main();