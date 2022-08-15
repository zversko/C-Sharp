// Напишите программу, которая задаёт массив из 8 элементов, выводит их на экран. И ищет второй максимум (элемент меньше максимального, но больше всех остальных)

int[] RandomArray(int Length)
{
    int[] array = new int[Length];
    int index = 0;
    while(index < array.Length)
    {
        array[index] = new Random().Next(0,100);
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
    int max1 = 0; 
    int max2 = 0;
    for(i = 0; i < count; i++)
    {
        if (a[i] > max1) 
        {
            max2 = max1;
            max1 = a[i];
        }
        if (a[i] > max2 && a[i] != max1) max2 = a[i];
    }
    Console.WriteLine();
    Console.Write($"Первый максимум - {max1} ; Второй максимум - {max2}");
}

PrintArray(RandomArray(8));