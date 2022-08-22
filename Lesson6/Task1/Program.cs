// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] RandomArray(int Length)
{
    int[] array = new int[Length];
    int index = 0;
    while(index < array.Length)
    {
        array[index] = new Random().Next(0,1000);
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

int[] ReverseArray(int[] a)
{
    int count = a.Length;
    int[] newA = new int[count];
    int i = 0;
    while (i < count)
    {
        newA[count - i - 1] = a[i];
        i++;
    }
    return newA;
}

int[] array = RandomArray(10);
PrintArray(array);
int[] newArray = ReverseArray(array);
PrintArray(newArray);
