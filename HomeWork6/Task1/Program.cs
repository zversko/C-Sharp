// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int number(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

void InputArray(int[] args)
{
    int length = args.Length;
    int index = 0;
    while (index < length)
    {
        Console.WriteLine($"Введите {index}-й элемент", index + 1);
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
        Console.WriteLine($"a[{position}] = {col[position]}");
        position++;
    }
}

int FindCountPos(int[] col)
{
    int count = 0;
    int position = 0;
    while (position < col.Length)
    {
        if (col[position] > 0) count++;
        position++;
    }
    return count;
}

void Main()
{
    int num = number("Введите количество элементов ");
    int[] array = new int[num];
    InputArray(array);
    PrintArray(array);
    Console.WriteLine($"Количество чисел больше 0 - {FindCountPos(array)}");
}

Main();