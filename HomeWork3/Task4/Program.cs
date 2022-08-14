// Сортировка массива методом вставки

int[] arr = { 9, 5, 4, 3, 2, 6, 7, 8, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    int count = 0;
    
    for (int i = 1; i < array.Length; i++)
    {
        for (int j = i; j > 0 && array[j - 1] > array[j]; j--)
        {
            count++;
            int temporary = array[j - 1];
            array[j - 1] = array[j];
            array[j] = temporary;         
        }
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);