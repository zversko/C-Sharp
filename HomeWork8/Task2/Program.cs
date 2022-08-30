// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int[] SumElementsInRow(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        array[i] = sum;
    }
    return array;
}

void PrintArray(int[] array)
{
    int count = array.Length;
    int i = 0;
    System.Console.WriteLine();
    while (i < count)
    {
        Console.WriteLine($"{i+1} строка - {array[i]}");
        i++;
    }
}

void PrintRowsWithMininimumSumElemenets(int[] array)
{
    int MinIndex = 0;
    int value = array[MinIndex];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < value)
        {
            value = array[i];
        }
    }
    System.Console.WriteLine("Строки с наименьшей суммой элементов:");
    for (int i = 0; i < array.Length; i++)                                  // Цикл с отдельной проверкой, т.к. строк с одинаковой суммой может быть несколько
    {
        if (value == array[i])
        {
            System.Console.Write($"{i+1}\t");
        }
    }

}

void Main()
{
    int rows = InputNumber("Укажите количество строк - ");
    int columns = InputNumber("Укажите количество столбцов - ");
    int[,] matrix = new int[rows, columns];
    RandomMatrix(matrix);
    PrintMatrix(matrix);
    Console.WriteLine();
    int[] array = SumElementsInRow(matrix);
    PrintArray(array);
    Console.WriteLine();
    PrintRowsWithMininimumSumElemenets(array);
}

Main();