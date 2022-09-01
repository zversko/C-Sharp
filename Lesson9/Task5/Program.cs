// Определите, является ли число степенью двойки:
// N = 16 -> "Является степень двойки"
// N = 12 -> “Не является степенью двойки”

int InputNumber(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

bool IsBinary(int number)
{
    if (number == 1)
    {
        return (true);
    }
    return IsBinary(number / 2) && (number % 2 == 0);
}

int number = InputNumber("Введите число > ");
bool result = IsBinary(number);
System.Console.WriteLine(result);

