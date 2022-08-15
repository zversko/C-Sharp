// Напечатать последовательность 1 2 2 3 3 3 4 4 4 4

int number(string message)
{
    Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

void PrintNumbers(int value)
{
    int count = 0;                              // Счетчик для подсчет колличества выведенных чисел
    int i = 0;                                  // Счетчик для группы одинаковых чисел
    while (true)                                // Внешний цикл групп
    {
        for(int j = 0; j < i; j++)              // Внутренний цикл для вывода чисел в группе
        {
            Console.Write($"{i} ");             // Вывод числа
            count++;                            // Увеличение счетчика
            if(count == value)                  // Условие выхода
            {
                return;
            }
        }
        i++;                                    // Счетчик групп
    }
}

int num = number("Введите число ");
PrintNumbers(num);