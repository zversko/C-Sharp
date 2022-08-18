// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] RandomArray(int Length)
{
    int[] array = new int[Length];
    int index = 0;
    while (index < array.Length)
    {
        array[index] = new Random().Next(-10, 0);
        index++;
    }
    return array;
}

void PrintArray(int[] a)
{
    int count = a.Length;
    int i = 0;
    while (i < count)
    {
        Console.Write($"{a[i]}  ");
        i++;
    }
    Console.WriteLine();
}

int FindOddSum(int[] a)
{
    int sum = 0;
    for (int i = 1; i < a.Length; i = i + 2)
    {
        sum += a[i];
    }
    return sum;
}

void Main()
{
    int[] array = RandomArray(10);
    PrintArray(array);
    Console.WriteLine($"Сумма нечентных элементов составляет - {FindOddSum(array)}");
}

Main();