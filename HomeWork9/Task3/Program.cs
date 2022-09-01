// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

int InputNumber(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}


int FunctionAkker(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (n == 0)
        return FunctionAkker(m - 1, 1);
    return FunctionAkker(m - 1, FunctionAkker(m, n - 1));
}

void Main () 
{
    int res = FunctionAkker(InputNumber("Введите первое число "), InputNumber("Введите второе число "));
    Console.WriteLine(res);
}

Main();