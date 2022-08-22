// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int[] DecArray()
{
    Console.WriteLine("Введите натуральное число");
    int NatNum = int.Parse(Console.ReadLine());
    int[] array = new int[10];
    int count = array.Length;
    int index = 0;
    while (index < count)
    {
        array[count - index - 1] = NatNum % 2;
        NatNum = NatNum / 2;
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

int[] array = DecArray();
PrintArray(array);