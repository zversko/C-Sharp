// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


int number(string message)
{
    Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int Pow(int a, int b)
{
    if (b == 0)
    {
        return 1;
    }

    return a * Pow (a, b - 1);
}

int a = number("Enter a > ");
int b = number("Enter b > ");
int power = Pow(a, b);
System.Console.WriteLine(power);