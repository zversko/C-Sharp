// Напишите программу, которая задаёт массив из 8 элементов, выводит их на экран. И ищет второй максимум (элемент меньше максимального, но больше всех остальных)

int[] RandomArray(int Length)
{
    int[] array = new int[Length];
    int index = 0;
    while(index < array.Length)
    {
        array[index] = new Random().Next(7,10);
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
}

void PrintMax(int[] a)
{
    int count = a.Length;
    int max1 = a[0]; 
    int max2 = a[0];
    for(int i = 0; i < count; i++)
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

int[] array = RandomArray(8);
PrintArray(array);
PrintMax(array);
