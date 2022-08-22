// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void InputArray(double[] a)
{
    for (int i = 0; i < 2; i++)
    {
        Console.WriteLine($"Введите угловой коэффициент и свободный член уравнения y = k{i + 1} * x + b{i + 1} (вначале вводим k, потом вводим b)");
        a[i * 2] = double.Parse(Console.ReadLine());
        a[i * 2 + 1] = double.Parse(Console.ReadLine());
    }

}

(double, double) FindXandY(double[] a)
{
    double findX = 0;
    double findY = 0;
    findX = (a[3] - a[1]) / (a[0] - a[2]);
    findY = a[2] * ((a[3] - a[1]) / (a[0] - a[2])) + a[3];
    return (findX, findY);
}

void Main()
{
    double[] array = new double[4];
    InputArray(array);
    (double findX, double findY) = FindXandY(array);
    Console.WriteLine($"Точа пересечения уравнений y = {array[0]} * x + {array[1]} и y = {array[2]} * x + {array[3]}");
    Console.WriteLine($"( {findX} , {findY} )");
}

Main();