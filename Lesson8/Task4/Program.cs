// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7



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

void PrintArray(int[] a)
{
    int count = a.Length;
    int i = 0;
    while (i < count)
    {
        Console.Write($"{a[i]}\t");
        i++;
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

int[] MinElementIndex(int[,] matrix)
{
    int[] answer = new int[2];
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            if (matrix[rows, columns] < matrix[answer[0], answer[1]])
            {
                answer[0] = rows;
                answer[0] = columns;
            }
        }
    }
    return answer;
}

int[] DeleteMin (int[,] matrix)
{
    int[] indexes = MinElementIndex(matrix);
    int[,] results = new int [matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    for (int rows = 1; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 1; columns < matrix.GetLength(1); columns++)
        {
            if(rows != indexes[0] && columns != indexes[1])
            {
            results[rows, columns] = matrix [rows, columns] 

            }
        }
    }
    return answer;
}

void Main()
{
    int rows = InputNumber("Укажите количество строк - ");
    int columns = InputNumber("Укажите количество столбцов - ");
    int[,] matrix = new int[rows, columns];
    RandomMatrix(matrix);
    PrintMatrix(matrix);
    FrequencyDictionary(matrix);
    Console.WriteLine();
    int[] answer = FrequencyDictionary(matrix);
    PrintArray(answer);
    Console.WriteLine();

}

Main();