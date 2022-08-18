// Напишите программу, которая задаёт массив из 8 элементов, выводит их на экран. И ищет второй максимум (элемент меньше максимального, но больше всех остальных)

int[] RandomArray(int Length)
{
    int[] array = new int[Length];
    int index = 0;
    while(index < array.Length)
    {
        array[index] = new Random().Next(6,9);
        index++;
    }
    return array;
}

int FindTwoMax(int[] a)
{
    int count = a.Length;
    int max1 = a[0] - a[1] - a[2]; 
    int max2 = a[0] - a[1] - a[2];
    for(int i = 0; i < count; i++)
    {
        if (a[i] > max1) 
        {
            max2 = max1;
            max1 = a[i];
        }
        if (a[i] > max2 && a[i] != max1) max2 = a[i];
    }
    return max2;
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

void PrintTwoMax(int max2)
{
    Console.WriteLine();
    Console.Write($"Второй максимум - {max2}");
}



int[] array = RandomArray(8);
PrintArray(array);
PrintTwoMax(FindTwoMax(array));
