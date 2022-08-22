// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

int number(string message)
{
    Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

bool Triangle(int a, int b, int c)
{
    if (a + b < c || b + c < a || c + a < b)
    {
        return false;
    }
    else
    {
        return true;
    }
}

int storA = number("Введите сторону A = ");
int storB = number("Введите сторону B = ");
int storC = number("Введите сторону C = ");
if (Triangle(storA, storB, storC))
{
    Console.WriteLine ("Треугольник существует");
}
else
{
    Console.WriteLine ("Треугольник не существует");
}