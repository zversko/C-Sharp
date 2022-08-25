// Задайте двумерный массив. Введите элемент, и найдите первое его вхождение, выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.
// Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Введенный элемент 2, результат: [1, 4]
// Введенный элемент 6, результат: такого элемента нет.

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