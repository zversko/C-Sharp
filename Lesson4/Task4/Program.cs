// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] RandomArray(int Length)
{
    int[] array = new int[Length];
    int index = 0;
    while(index < array.Length)
    {
        array[index] = new Random().Next(0,2);
        index++;
    }
    return array;
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int index = 0;
    while (index < count)
    {
        Console.Write($"{col[index]} ");
        index++;
    }
}

int[] array = RandomArray(10);
PrintArray(array);