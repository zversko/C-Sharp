int InputNum()
{
    Console.WriteLine("Ведите номер задачи, который хотите решить:");
    Console.WriteLine("1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
    Console.WriteLine("2. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.");
    Console.WriteLine("3. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
    Console.WriteLine("4. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
    int Task = int.Parse(Console.ReadLine());
    if(Task < 1 || Task > 4)
    {
        Console.WriteLine("Нет такой задачи");
        return 0;
    }
    else
    {
        return Task;
    }
}

int Questions(int Task)
{
    if(Task == 1)
    {
        int[] array = InputArray1();
    }

    if(Task == 2)
    {
        int[] array = InputArray2();
    }

    if(Task == 3)
    {
        int[] array = InputArray3();    
    }

    if(Task == 4)
    {
        int day = Day();    
    }

    return 0;
}

int[] InputArray1()
{
    Console.WriteLine("Введите натуральное число");
    int NatNum = int.Parse(Console.ReadLine());
    int digitCount = (int)Math.Log10(NatNum) + 1;
    int[] array = new int[digitCount];
    int index = 0;
    if(digitCount == 3) 
    {
        while(index < digitCount)
        {
           array[digitCount - index - 1] = NatNum % 10;
           NatNum = NatNum / 10;
            index++;
        }
        Console.WriteLine($"Второй элемент числа = {array[1]}");
    }
    else
    {
        Console.WriteLine("Число не трехзначное");
    }
    return array;
}

int[] InputArray2()
{
    int NatNum = new Random().Next(100,999);
    int digitCount = (int)Math.Log10(NatNum) + 1;
    int[] array = new int[digitCount];
    int index = 0;
    while(index < digitCount)
    {
        array[digitCount - index - 1] = NatNum % 10;
        NatNum = NatNum / 10;
        index++;
    }
    Console.WriteLine($"Случайное число - {array[0]}{array[1]}{array[2]}");
    Console.WriteLine($"Так будет выглядеть число без второго элемента - {array[0]}{array[2]}");
    return array;
}

int[] InputArray3()
{
    Console.WriteLine("Введите натуральное число");
    int NatNum = int.Parse(Console.ReadLine());
    int digitCount = (int)Math.Log10(NatNum) + 1;
    int[] array = new int[digitCount];
    int index = 0;
    if(digitCount > 2)
    {
        while(index < digitCount)
        {
            array[digitCount - index - 1] = NatNum % 10;
            NatNum = NatNum / 10;
            index++;
        }
    Console.WriteLine($"Третий элемент числа = {array[2]}");
    }
    else
    {
        Console.WriteLine("Веденное число меньше 100");
    }
    return array;
}

int Day()
{
    Console.WriteLine("Введите натуральное число от 1 до 7");
    int NatNum = int.Parse(Console.ReadLine());
    if(NatNum > 0 && NatNum < 8)
    {
        if(NatNum == 6 || NatNum == 7)
        {
            Console.WriteLine("Указанная цифра соответствует выходному дню недели");
        }
        else
        {
            Console.WriteLine("Указанная цифра соответствует рабочему дню недели");
        }
    }
    else
    {
        Console.WriteLine("Указанная цифра не входит в дипазон от 1 до 7");
    }
    return 0;
}

int Task = InputNum();
int Q = Questions(Task);




