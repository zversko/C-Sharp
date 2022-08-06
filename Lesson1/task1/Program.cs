Console.Write("Введите число 1 - ");
string readA = Console.ReadLine();
int a = int.Parse(readA);
Console.Write("Введите число 2 - ");
string readB = Console.ReadLine();
int b = int.Parse(readB);
if (b == a*a)
{
    Console.WriteLine($"Число {a} является квадратом числа {b}");
}
else
{
    Console.WriteLine($"Число {a} не является квадратом числа {b}");
}    
