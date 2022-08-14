// Задача 2.
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int number(string message)
{
    Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}


double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double dist = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    return dist;
}

void start()
{
    Console.WriteLine("Координаты первой точки:");
    int x1 = number("Введите координату по первой оси - ");
    int y1 = number("Введите координату по второй оси - ");
    int z1 = number("Введите координату по третьей оси - ");
    Console.WriteLine("Координаты второй точки:");
    int x2 = number("Введите координату по первой оси - ");
    int y2 = number("Введите координату по второй оси - ");
    int z2 = number("Введите координату по третьей оси - ");

    double Dist = Distance(x1, y1, z1, x2, y2, z2);
    Console.WriteLine($"Расстояние между двумя точками = {Dist}");
}

start();