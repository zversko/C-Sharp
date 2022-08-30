// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных. Значения элементов массива 0..9


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

int[] FrequencyDictionary(int[,] matrix)
{
    int[] answer = new int[10];
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            answer[matrix[rows, columns]]++;
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