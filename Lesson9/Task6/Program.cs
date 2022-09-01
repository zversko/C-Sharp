// Проверка на простое число: 
// N = 13 -> "Это простое число"
// N = 12 -> “Это не простое число”


int InputNumber(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

bool PrimeNumber(int num, int divider)
{
    if (divider == 1)
    {
        return true;
    }
    return PrimeNumber(num, divider - 1) && (num % divider > 0);
}

int number = InputNumber("Введите число > ");
int divider = number - 1;
bool result = PrimeNumber(number, divider);
System.Console.WriteLine(result);
