// Задайте значения M и N. Напишите программу, которая рекурсивно выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


int InputNumber(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

void ShowNaturalRow(int min, int max)
{
    if(max <= min)
    {
        return;
    }

    ShowNaturalRow(min, max - 1);
    System.Console.WriteLine(max);
}

int number1 = InputNumber("Введит число > ");
int number2 = InputNumber("Введит число > ");
ShowNaturalRow(number1, number2);
