// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт 
// максимальное из этих чисел. 2, 3, 7 -> 7
// Решение переделал после лекции, т.к. на лекции проходили массивы

void InputArray(int[] args)
{
    int length = args.Length;
    int index = 0;
    while(index < length)
    {
        Console.WriteLine("Введите {0}-й элемент", index + 1);
        args[index] = int.Parse(Console.ReadLine());
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int MaxArray(int[] args)
{
    int length = args.Length;
    int index = 1;
    int Max = args[index - 1];
    while(index < length)
    {
        if(args[index] > Max) Max = args[index];
        index++;
    }
    return Max;
}

int[] array = new int[3];
InputArray(array);
PrintArray(array);
int MaxAr = MaxArray(array);

Console.WriteLine($"Максимальный элемент массива {MaxAr}");