// Со звездочкой(*). Найдите максимальное значение в матрице по каждой строке, ссумируйте их. 
// Затем найдети минимальное значение по каждой колонке, тоже ссумируйте их. 
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)

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

int SumMaximumRows(int[,] matrix)
{
    int sum = 0; 
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        int max = matrix[rows, 0];
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            if (matrix[rows, columns] > max) 
            {
                max = matrix[rows, columns];
            }    
        }
        sum += max;
    }
    return sum;
}

int SumMinimumColumns(int[,] matrix)
{
    int sum = 0;
    for (int columns = 0; columns < matrix.GetLength(1); columns++)
    {
        int min = matrix[0, columns];
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            if (matrix[rows, columns] < min) 
            {
                min = matrix[rows, columns];
            }
        }
        sum += min;
    }
    return sum;
}

void Main()
{
    int rows = InputNumber("Укажите количество строк - ");
    int columns = InputNumber("Укажите количество столбцов - ");
    Console.WriteLine();
    int[,] matrix = new int[rows, columns];
    RandomMatrix(matrix);
    PrintMatrix(matrix);
    int maxrows = SumMaximumRows(matrix);
    int mincolumns = SumMinimumColumns(matrix);
    Console.WriteLine();
    Console.WriteLine($"Сумма максимумов среди строк = {maxrows}");
    Console.WriteLine($"Сумма минимумов среди столбцов = {mincolumns}");
    Console.WriteLine($"Разница между суммами равна = {maxrows - mincolumns}");
    Console.WriteLine();
}

Main();