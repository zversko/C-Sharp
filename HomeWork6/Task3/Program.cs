// Со Звездочкой (*). Сгенерировать двумерный массив со случайными числами, вывести его на экран, оформить в виде функций (пригодится в дальнейшем)

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

void Main()
{
    int[,] matrix = new int[10, 10];
    PrintArray(matrix);
    Console.WriteLine();
    RandomArray(matrix);
    PrintArray(matrix);
    Console.WriteLine();
}

Main();