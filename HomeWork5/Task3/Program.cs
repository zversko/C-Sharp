// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7.3 22.2 2 78] -> 76

double[] RandomArray(int Length)
{
    double[] array = new double[Length];
    int index = 0;
    while (index < array.Length)
    {
        array[index] = Math.Round((new Random().NextDouble() * 100), 3);
        index++;
    }
    return array;
}

void PrintArray(double[] a)
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

(double, double, double) FindEl(double[] a)
{
    int i = 0;
    double MaxEl = a[i];
    double MinEl = a[i];
    double diff = 0;
    for (i = 0; i < a.Length; i++)
    {
        if (a[i] > MaxEl) MaxEl = a[i];
        if (a[i] < MinEl) MinEl = a[i];
    }
    diff = Math.Round(MaxEl - MinEl, 3);
    return (MaxEl, MinEl, diff);
}

void Main()
{
    double[] array = RandomArray(10);
    PrintArray(array);
    (double MaxEl, double MinEl, double diff) = FindEl(array);
    Console.WriteLine($"Минимальный элемент массива {MinEl}, а максимальный элемент массива {MaxEl}");
    Console.WriteLine($"Разница между элементами пассоила - составляет {diff}");
}

Main();