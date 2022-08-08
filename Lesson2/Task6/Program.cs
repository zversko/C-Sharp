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
    while(index < length)
    {
        Console.WriteLine("Введите {0}-й элемент", index + 1);
        args[index] = int.Parse(Console.ReadLine());
        index++;
    }
}

int Summ(int[] args)
{
    int length = args.Length;
    int index = 0;
    int sum = 0;
    while(index < length)
    {
        sum = sum + args[index];
        index++;
    }
    return sum;
}

int N; 
N = number("Введите размер массива ");

int[] array = new int[N];
InputArray(array);
int SumEl = Summ(array);
double Aver = SumEl / ((double)N);

Console.WriteLine($"Сумма равна {SumEl}");
Console.WriteLine($"Среднее значение {Aver}");