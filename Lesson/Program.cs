// See https://aka.ms/new-console-template for more information


// Функция на вход получает параметр, на выходе введеное с консоли значение
int Prompt(string message)
{
    System.Console.Write(message); // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue); // Преобразует строку в целое число
    return result; // Возвращает результат
}

int value;  // Объявление переменной
value = Prompt("Введите число > ");  //Вводим значение
int result = value * value; // Выяисляем квадрат
System.Console.WriteLine($"Квадрат числа {vlaue} равен {result}"); // Вывод результата